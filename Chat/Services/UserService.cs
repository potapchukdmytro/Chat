using AutoMapper;
using Chat.Constants;
using Chat.Entites;
using Chat.Repositories;
using Chat.Validation;
using Chat.ViewModels.Auth;
using Chat.ViewModels.User;
using Microsoft.EntityFrameworkCore;

namespace Chat.Services
{
    public class UserService
    {
        private readonly GenericRepository<Guid, UserEntity> userRepository;
        private readonly IMapper mapper;
        public UserEntity CurrentUser { get; set; } = null;

        public UserService(GenericRepository<Guid, UserEntity> userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public UserEntity? GetById(Guid id)
        {
            var user = userRepository
                .GetAll()
                .Include(u => u.Messages)
                .Include(u => u.UserChats)
                .ThenInclude(uc => uc.Chat)
                .FirstOrDefault(u => u.Id == id);
            return user;
        }

        public UserEntity? GetUser(Func<UserEntity, bool> pred)
        {
            return GetAll().FirstOrDefault(pred);
        }

        public bool HasUser(Func<UserEntity, bool> pred) 
        {
            var user = userRepository
                .GetAll()
                .FirstOrDefault(pred);
            return user != null;
        }

        public bool HasUser(UserEntity entity)
        {
            return HasUser(u => u.Email == entity.Email || u.UserName == entity.UserName);
        }

        public List<UserEntity> GetAll()
        {
            var users = userRepository
                .GetAll()
                .Include(u => u.Messages)
                .Include(u => u.UserChats)
                .ThenInclude(uc => uc.Chat)
                .ToList();
            return users;
        }

        public bool Create(UserEntity entity)
        {
            try
            {
                if (HasUser(u => u.Email == entity.Email) || HasUser(u => u.UserName == entity.UserName))
                {
                    return false;
                }
                return userRepository.Create(entity);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Response Login(LoginVM model)
        {
            LoginValidator validator = new LoginValidator();
            var validationResult = validator.Validate(model);

            if (!validationResult.IsValid)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = validationResult.Errors[0].ErrorMessage
                };
            }

            var entity = GetUser(u => u.Email == model.Login.ToLower() 
                                || u.UserName == model.Login.ToLower());

            if(entity == null)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Логін або пароль вказані не вірно"
                };
            }

            if(entity.Password != model.Password)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Логін або пароль вказані не вірно"
                };
            }

            CurrentUser = entity;

            return new Response { IsSuccess = true, Message = "Успішний вхід" };
        }

        public Response Register(RegisterVM model)
        {
            var validator = new RegisterValidator();

            var validationResult = validator.Validate(model);

            if (!validationResult.IsValid)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = validationResult.Errors[0].ErrorMessage
                };
            }

            var entity = mapper.Map<UserEntity>(model);

            if(HasUser(entity))
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Користувач з таким іменем вже існує"
                };
            }

            Create(entity);

            CurrentUser = entity;

            return new Response
            {
                IsSuccess = true,
                Message = "Користувач успішно зареєстрований"
            };
        }

        public Response ProfileChange(ProfileVM model)
        {
            var validator = new ProfileValidator();

            var validationResult = validator.Validate(model);

            if(!validationResult.IsValid)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = validationResult.Errors[0].ErrorMessage
                };
            }

            var newEntity = mapper.Map<UserEntity>(model);

            if(HasUser(u => 
            (u.Email == newEntity.Email || u.UserName == newEntity.UserName) && u.Id != newEntity.Id))
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Пошта або логін вже використовуються"
                };
            }

            newEntity.CreatedDate = CurrentUser.CreatedDate;
            newEntity.IsDeleted = CurrentUser.IsDeleted;
            newEntity.UserChats = CurrentUser.UserChats;
            newEntity.Messages = CurrentUser.Messages;

            if (CurrentUser.Image != newEntity.Image)
            {
                if (!string.IsNullOrEmpty(CurrentUser.Image))
                {
                    File.Delete(Path.Combine(PathFiles.Images, CurrentUser.Image));
                }

                model.Image.Save(Path.Combine(PathFiles.Images, newEntity.Image));
            }

            CurrentUser = newEntity;

            Update(CurrentUser);

            return new Response
            {
                IsSuccess = true,
                Message = "Дані успішно змінено"
            };
        }

        public void Update(UserEntity entity)
        {
            userRepository.Update(entity);
        }
    }
}
