using MicroRabbit.Dommain.Core.Bus;
using MicroRabbit.Tranfer.Domain.Events;
using MicroRabbit.Tranfer.Domain.Interfaces;
using MicroRabbit.Tranfer.Domain.Model;
using System.Threading.Tasks;

namespace MicroRabbit.Tranfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;
        public TransferEventHandler(ITransferRepository transferRepository)
        {
            transferRepository = _transferRepository;
        }

        public Task Handle(TransferCreatedEvent @event)
        {
            _transferRepository.Add(new TransferLog()
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                TransferAmoun = @event.Amount
            });

            return Task.CompletedTask;
        }
    }
}
