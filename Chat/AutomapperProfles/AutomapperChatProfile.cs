using AutoMapper;
using Chat.Entites;
using Chat.ViewModels.Chat;

namespace Chat.AutomapperProfles
{
    public class AutomapperChatProfile : Profile
    {
        public AutomapperChatProfile()
        {
            CreateMap<ChatEntity, ChatVM>();
        }
    }
}
