using AutoMapper;
using Chat.AutomapperProfles;
using Chat.Entites;
using Chat.Repositories;
using Chat.Services;

namespace Chat.Configuration
{
    public class Config
    {
        public UserService userService;
        public ChatService chatService;
        public LogService logService;
        public IMapper mapper;
        public MapperConfiguration mapperConfig;

        public Config() 
        {
            AppDbContext context = new AppDbContext();
            GenericRepository<Guid, UserEntity> userRepository = new GenericRepository<Guid, UserEntity>(context);
            GenericRepository<Guid, ChatEntity> chatRepository = new GenericRepository<Guid, ChatEntity>(context);
            GenericRepository<Guid, MessageEntity> messageRepository = new GenericRepository<Guid, MessageEntity>(context);
            GenericRepository<Guid, LogEntity> logRepository = new GenericRepository<Guid, LogEntity>(context);
            UserChatRepository userChatRepository = new UserChatRepository(context);

            mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutomapperUserProfile>();
                cfg.AddProfile<AutomapperChatProfile>();
                cfg.AddProfile<AutomapperMessageProfile>();
            });

            mapper = new Mapper(mapperConfig);

            userService = new UserService(userRepository, mapper);
            chatService = new ChatService(chatRepository, mapper, userService, userChatRepository, messageRepository);
            logService = new LogService(logRepository);
        }
    }
}
