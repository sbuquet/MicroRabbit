namespace MicroRabbit.Tranfer.Domain.Model
{
    public class TransferLog
    {
        public int Id { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmoun { get; set; }
    }
}
