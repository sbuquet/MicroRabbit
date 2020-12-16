using MicroRabbit.Tranfer.Domain.Model;
using System.Collections.Generic;

namespace MicroRabbit.Tranfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();

        void Add(TransferLog transferLog);
    }
}
