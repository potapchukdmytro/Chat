using Chat.Entites;
using Chat.Repositories;

namespace Chat.Services
{
    public enum LogTypes
    {
        RegisterError,
        RegisterSuccess,
        LoginError,
        LoginSuccess,
        Exception
    }

    public class LogService
    {
        private readonly GenericRepository<Guid, LogEntity> logRepository;

        public LogService(GenericRepository<Guid, LogEntity> logRepository)
        {
            this.logRepository = logRepository;
        }

        public void AddLog(string message, string type)
        {
            try
            {
                var entity = new LogEntity
                {
                    Message = message,
                    Type = type,
                    Id = Guid.NewGuid()
                };

                logRepository.Create(entity);
            }
            catch (Exception)
            {
            }
        }
    }
}
