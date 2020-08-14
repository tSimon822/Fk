using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oooooo.Models
{
    public class reservationViewModel
    {
        public int fReservationId { get; set; }
        public string fReservationType { get; set; }
        public string fUserId { get; set; }
        public Nullable<System.DateTime> fReservationDate { get; set; }
        public string fReservationTime { get; set; }
        public Nullable<int> fnumReservation { get; set; }
        public string fRemark { get; set; }
    }
}