using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStoreManagementSystem.Entities
{
    [Table("Stock")]
    public class Stock
    {
        public string ItemName { get; set; }
        public string ItemDetail { get; set; }
        public double Price { get; set; }
        public long Quantity { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
