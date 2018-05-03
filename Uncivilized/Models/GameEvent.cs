using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Uncivilized.Models
{
    [Table("GameEvents")]
    public class GameEvent
    {
        [Key]
        public int GameEventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Capital { get; set; }
        public int Resouces { get; set; }
        public int Population { get; set; }
    }
}
