using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Siniflar
{
    public class Map
    {
        [Key]
        public int Id { get; set; }
        public int Location { get; set; }
        public int Userid { get; set; }
        public virtual User User { get; set; }

    }
}