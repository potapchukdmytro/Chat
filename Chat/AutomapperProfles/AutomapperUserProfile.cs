using AutoMapper;
using Chat.Constants;
using Chat.Entites;
using Chat.ViewModels.Auth;
using Chat.ViewModels.User;

namespace Chat.AutomapperProfles
{
    public class AutomapperUserProfile : Profile
    {
        public AutomapperUserProfile() 
        {
            // UserEntity -> ProfileVM
            CreateMap<UserEntity, ProfileVM>()
                .ForMember(dest => dest.Image, opt => opt.Ignore());
            // ProfileVM -> UserEntity
            CreateMap<ProfileVM, UserEntity>()
                .ForMember(dest => dest.Messages, opt => opt.Ignore())
                .ForMember(dest => dest.UserChats, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.IsDeleted, opt => opt.Ignore())
                .ForMember(dest => dest.Image, opt => opt
                    .MapFrom(src => src.Image == null ? null : src.Image.Tag.ToString()));
            // RegisterVM -> UserEntity
            CreateMap<RegisterVM, UserEntity>()
                .ForMember(dest => dest.Messages, opt => opt.Ignore())
                .ForMember(dest => dest.UserChats, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => false))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName.ToLower()))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email.ToLower()));
            // UserEntity -> UserListVM
            CreateMap<UserEntity, UserListVM>();
        }
    }
}
