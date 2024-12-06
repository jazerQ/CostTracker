using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegLog.Models
{
    public class Transactions
    {
        [Key]
        public int TransactionId { get; set; }
        public int Amount { get; set; }
        public string Descriptions { get; set; }
        public DateTime Date { get; set; }
    }
}
