using AutoMapper;
using Chat.Entites;
using Chat.Repositories;
using Chat.Validation;
using Chat.ViewModels.Chat;
using Chat.ViewModels.Message;
using Chat.ViewModels.User;
using Microsoft.EntityFrameworkCore;

namespace Chat.Services
{
    public class ChatService
    {
        private readonly GenericRepository<Guid, ChatEntity> chatRepository;
        private readonly GenericRepository<Guid, MessageEntity> messageRepository;
        private readonly UserChatRepository userChatRepository;
        private readonly UserService userService;
        private readonly IMapper mapper;

        public ChatService(GenericRepository<Guid, ChatEntity> chatRepository, IMapper mapper, UserService userService, UserChatRepository userChatRepository, GenericRepository<Guid, MessageEntity> messageRepository)
        {
            this.chatRepository = chatRepository;
            this.mapper = mapper;
            this.userService = userService;
            this.userChatRepository = userChatRepository;
            this.messageRepository = messageRepository;
        }

        public List<UserListVM> GetUsers(Guid chatId)
        {
            var chat = GetById(chatId);

            if (chat == null)
            {
                return new List<UserListVM>();
            }

            var usersEntity = chat.UserChats.Select(uc => uc.User).ToList();

            var usersModel = mapper.Map<List<UserListVM>>(usersEntity);

            return usersModel;
        }

        public Response AddUser(Guid chatId, Guid userId)
        {
            try
            {
                var chatEntity = GetById(chatId);
                var userEntity = userService.GetById(userId);

                if (chatEntity == null || userEntity == null)
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        Message = "Такого чату або користувача не існує"
                    };
                }


                if (UserInChat(chatId, userId))
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        Message = "Даний користувач вже є у чаті"
                    };
                }

                var userChatEntity = new UserChatEntity
                {
                    ChatId = chatId,
                    UserId = userId
                };

                userChatRepository.Create(userChatEntity);

                return new Response()
                {
                    IsSuccess = true,
                    Message = "Успішно додано"
                };
            }
            catch (Exception ex)
            {
                return new Response()
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public bool UserInChat(Guid chatId, Guid userId)
        {
            var res = userChatRepository.GetByIds(userId, chatId);
            return res != null;
        }

        public List<ChatVM> GetAll()
        {
            var chatsEntity = chatRepository.GetAll().ToList();

            var chats = mapper.Map<List<ChatVM>>(chatsEntity);

            return chats;
        }

        public List<ChatVM> GetAll(Guid userId)
        {
            var chatsEntity = chatRepository
                .GetAll()
                .Include(c => c.UserChats)
                .Where(c => c.UserChats.Count(uc => uc.UserId == userId) > 0)
                .ToList();

            var chats = mapper.Map<List<ChatVM>>(chatsEntity);

            return chats;
        }

        public List<ChatVM> GetJoinChatList(Guid userId)
        {
            var chatsEntity = chatRepository
                .GetAll()
                .Include(c => c.UserChats)
                .Where(c => c.UserChats.All(uc => uc.UserId != userId))
                .ToList();

            var chats = mapper.Map<List<ChatVM>>(chatsEntity);

            return chats;
        }

        public ChatEntity GetById(Guid id)
        {
            var entitiy = chatRepository
                            .GetAll()
                            .Include(c => c.UserChats)
                            .ThenInclude(uc => uc.User)
                            .FirstOrDefault(c => c.Id == id);
            return entitiy;
        }

        public bool HasChat(string title)
        {
            var res = chatRepository.GetAll().FirstOrDefault(c => c.Title.ToLower() == title.ToLower());

            return res != null;
        }

        public Response CreateChat(CreateChatVM model)
        {
            try
            {
                CreateChatValidator validator = new CreateChatValidator();

                var validatorRes = validator.Validate(model);

                if (!validatorRes.IsValid)
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        Message = validatorRes.Errors[0].ErrorMessage
                    };
                }

                var user = userService.GetById(model.UserId);

                if (user == null)
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        Message = "User null"
                    };
                }

                if (HasChat(model.Title))
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        Message = "Чат з таким іменем вже існує"
                    };
                }

                var entity = new ChatEntity
                {
                    Title = model.Title,
                    Id = Guid.NewGuid()
                };

                chatRepository.Create(entity);


                var userChatEntity = new UserChatEntity
                {
                    UserId = user.Id,
                    ChatId = entity.Id
                };

                var createRes = userChatRepository.Create(userChatEntity);

                if (!createRes)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = $"Невідома помилка при створенні чату"
                    };
                }

                return new Response
                {
                    IsSuccess = true,
                    Message = $"Чат {entity.Title} створено"
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }

        }

        public void AddMessage(CreateMessageVM model)
        {
            try
            {
                var messageEntity = mapper.Map<MessageEntity>(model);

                messageRepository.Create(messageEntity);
            }
            catch (Exception)
            {
            }
        }

        public List<MessageVM> GetMessages(Guid id)
        {
            try
            {
                var chat = chatRepository
                    .GetAll()
                    .Include(c => c.Messages)
                    .ThenInclude(m => m.User)
                    .FirstOrDefault(c => c.Id == id);

                if (chat == null)
                {
                    return new List<MessageVM>();
                }

                chat.Messages.ForEach(m => m.Chat = chat);

                var res = mapper.Map<List<MessageVM>>(chat.Messages);

                return res;
            }
            catch (Exception)
            {
                return new List<MessageVM>();
            }
        }
    }
}
