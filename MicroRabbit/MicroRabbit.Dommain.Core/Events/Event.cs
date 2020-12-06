using System;

namespace MicroRabbit.Dommain.Core.Events
{
    public abstract class Event
    {
        public DateTime Timestamp { get; set; }

        protected Event()
        {
            this.Timestamp = DateTime.Now;
        }
    }
}
