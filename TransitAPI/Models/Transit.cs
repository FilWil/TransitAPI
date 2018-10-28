using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransitAPI.Models
{
    public class Transit
    {
        public int ID { get; set; }

        [Required]
        public string SourceAddress { get; set; }

        [Required]
        public string DestinationAddress { get; set; }

        [Required]
        public double Range { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
    }
}
