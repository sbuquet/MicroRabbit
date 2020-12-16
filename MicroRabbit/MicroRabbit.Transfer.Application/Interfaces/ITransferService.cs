using MicroRabbit.Tranfer.Domain.Model;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Application
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
