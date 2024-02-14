using AutoMapper;
using Chat.Entites;
using Chat.ViewModels.Message;

namespace Chat.AutomapperProfles
{
    public class AutomapperMessageProfile : Profile
    {
        public AutomapperMessageProfile() 
        {
            // MessageEntity -> MessageVM
            CreateMap<MessageEntity, MessageVM>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.CreatedDate))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.UserName))
                .ForMember(dest => dest.ChatName, opt => opt.MapFrom(src => src.Chat.Title));
            // CreateMessageVM -> MessageEntity
            CreateMap<CreateMessageVM, MessageEntity>();
        }
    }
}
