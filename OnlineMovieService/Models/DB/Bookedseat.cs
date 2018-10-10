using System;
using System.Collections.Generic;

namespace OnlineMovieService.Models.DB
{
    public partial class Bookedseat
    {
        public int? Bookingid { get; set; }
        public int? Seatno { get; set; }
        public int Ticketno { get; set; }

        public Bookingdetails Booking { get; set; }
    }
}
