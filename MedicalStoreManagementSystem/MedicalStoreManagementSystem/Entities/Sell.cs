using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStoreManagementSystem.Entities
{
    [Table("Sell")]
    public class Sell
    {
        public string ClientName { get; set; }
        public string ItemName { get; set; }
        public long Quantity { get; set; }
        public double Rate { get; set; }
        public DateTime Date { get; set; }
    }
}
