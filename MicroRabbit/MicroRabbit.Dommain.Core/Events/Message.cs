using MediatR;

namespace MicroRabbit.Dommain.Core.Events
{
    public class Message : IRequest<bool>
    {
        public string MessageType { get; protected set; }

        protected Message()
        {
            this.MessageType = GetType().Name;
        }
    }
}
