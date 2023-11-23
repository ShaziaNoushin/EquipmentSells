using EquipmentSells.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EquipmentSells.Viewmodels
{
    public class EquipmentInputViewmodel
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
            public string Picture { get; set; }

        
    }
}