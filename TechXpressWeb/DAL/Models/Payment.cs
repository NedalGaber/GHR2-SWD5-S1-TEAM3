using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public decimal Amount { get; set; }
        public int PaymentId { get; set; }
        public PaymentMethod Method { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;
    }

}
