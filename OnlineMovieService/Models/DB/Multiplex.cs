using System;
using System.Collections.Generic;

namespace OnlineMovieService.Models.DB
{
    public partial class Multiplex
    {
        public Multiplex()
        {
            MultiplexHall = new HashSet<MultiplexHall>();
            Shows = new HashSet<Shows>();
        }

        public int MultiplexId { get; set; }
        public string MultiplexName { get; set; }
        public string MultiplexCity { get; set; }
        public string MultiplexEmailId { get; set; }
        public string MultiplexPhoneno { get; set; }

        public ICollection<MultiplexHall> MultiplexHall { get; set; }
        public ICollection<Shows> Shows { get; set; }
    }
}
