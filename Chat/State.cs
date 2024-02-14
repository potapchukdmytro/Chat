using Chat.Entites;

namespace Chat
{
    public class State
    {
        private static State instance = null;
        private State() { }

        public UserEntity User { get; set; } = null;

        public static State GetInstance()
        {
            if(instance == null)
            {
                instance = new State();
            }

            return instance;
        }
    }
}
