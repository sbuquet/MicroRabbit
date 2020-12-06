﻿using MicroRabbit.Dommain.Core.Commands;
using MicroRabbit.Dommain.Core.Events;
using System.Threading.Tasks;

namespace MicroRabbit.Dommain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>() 
            where T : Event 
            where TH : IEventHandler<T>;
    }
}
