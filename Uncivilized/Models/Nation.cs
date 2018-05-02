using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Uncivilized.Models
{
    [Table("Nations")]
    public class Nation
    {
        [Key]
        public int NationId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Government { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
        public int Happiness { get; set; }
        public int Capital { get; set; }
        public int Resources { get; set; }
    }
}
