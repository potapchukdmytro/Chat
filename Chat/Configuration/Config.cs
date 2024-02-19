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
        public AppDbContext appDbContext;

        public Config() 
        {
            appDbContext = new AppDbContext();
            GenericRepository<Guid, UserEntity> userRepository = new GenericRepository<Guid, UserEntity>(appDbContext);
            GenericRepository<Guid, ChatEntity> chatRepository = new GenericRepository<Guid, ChatEntity>(appDbContext);
            GenericRepository<Guid, MessageEntity> messageRepository = new GenericRepository<Guid, MessageEntity>(appDbContext);
            GenericRepository<Guid, LogEntity> logRepository = new GenericRepository<Guid, LogEntity>(appDbContext);
            GenericRepository<Guid, RoleEntity> roleRepository = new GenericRepository<Guid, RoleEntity>(appDbContext);
            UserChatRepository userChatRepository = new UserChatRepository(appDbContext);

            mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutomapperUserProfile>();
                cfg.AddProfile<AutomapperChatProfile>();
                cfg.AddProfile<AutomapperMessageProfile>();
            });

            mapper = new Mapper(mapperConfig);

            userService = new UserService(userRepository, mapper, roleRepository);
            chatService = new ChatService(chatRepository, mapper, userService, userChatRepository, messageRepository);
            logService = new LogService(logRepository);
        }
    }
}
