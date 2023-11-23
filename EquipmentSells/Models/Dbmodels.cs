using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EquipmentSells.Models
{
    
        public enum EquipmentType { light, Heavy, HighLoad }
    public class Equipment
    {
        public int EquipmentId { get; set; }
        [Required, StringLength(50)]
        public string Code { get; set; }
        [Required, EnumDataType(typeof(EquipmentType))]
        public EquipmentType Type { get; set; }
        [Required, StringLength(50)]
        
        public string Sender { get; set; }
        [Required, StringLength(50)]
        public DateTime DeliveryDate { get; set; }
        [Required, DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public bool Available { get; set; }
        [Required, StringLength(30)]
        public HttpPostedFileBase Picture { get; set; }

    }
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required, StringLength(50)]
        public string CustomerName { get; set; }
        [Required, StringLength(20)]
        public string CustomerAddress { get; set; }
        [Required]
        public string RecieveContactNumber { get; set; } 
      

    }
    
}