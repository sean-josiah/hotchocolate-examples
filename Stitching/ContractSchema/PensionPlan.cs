using System;

namespace Demo.Contracts
{
    public class PensionPlan
        : IContract
    {
        public string Id { get; set; }

        public string CustomerId { get; set; }

        public Decimal AmmountSaved { get; set; }

        public DateTime DueDate { get; set; }
    }
}
