using Edu.Entity.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Entity.Entities
{
    public class Ticket : BaseEntity
    {
        [ForeignKey("Customers")]
        public int CustomerId { get; set; }
        public Customer Customers { get; set; }

        [ForeignKey("ShowTimes")]
        public int ShowTimeId { get; set; }
        public ShowTime ShowTimes { get; set; }
        public string SeatNumber { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
       public enum PaymentMethod
        {
            Cash,
            CreditCart,
            DebitCart,
            DigitalWallet
        }
        public PaymentMethod PaymentType { get; set; }
    }
}
