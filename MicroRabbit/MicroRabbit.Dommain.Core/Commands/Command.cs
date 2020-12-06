using MicroRabbit.Dommain.Core.Events;
using System;

namespace MicroRabbit.Dommain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            this.Timestamp = DateTime.Now;
        }
    }
}
