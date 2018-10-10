using System;
using System.Collections.Generic;

namespace OnlineMovieService.Models.DB
{
    public partial class MultiplexHall
    {
        public MultiplexHall()
        {
            Shows = new HashSet<Shows>();
        }

        public int HallId { get; set; }
        public int MultiplexId { get; set; }
        public string HallName { get; set; }
        public int TotalSeats { get; set; }

        public Multiplex Multiplex { get; set; }
        public ICollection<Shows> Shows { get; set; }
    }
}
