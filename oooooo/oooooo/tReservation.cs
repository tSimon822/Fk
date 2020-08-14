namespace oooooo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class tReservation
    {
        [DisplayName("序號")]
        public int fReservationId { get; set; }
        [DisplayName("預約種類")]
        public string fReservationType { get; set; }
        [DisplayName("預約住戶")]
        public string fUserId { get; set; }
        [DisplayName("預約日期")]
        public Nullable<System.DateTime> fReservationDate { get; set; }
        [DisplayName("預約時間")]
        public Nullable<int> fReservationTimeId { get; set; }
        [DisplayName("服務人員人數")]
        public Nullable<int> fnumReservation { get; set; }
        [DisplayName("備註")]
        public string fRemark { get; set; }
    
        public virtual tMemberData tMemberData { get; set; }
        public virtual tReservationTime tReservationTime { get; set; }
    }
}
