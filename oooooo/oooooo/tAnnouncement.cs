//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace oooooo
{
    using System;
    using System.Collections.Generic;
    
    public partial class tAnnouncement
    {
        public int fAnnouncementId { get; set; }
        public string fAnnTitle { get; set; }
        public string fAnnDate { get; set; }
        public string fUserId { get; set; }
        public string fAnnContent { get; set; }
        public Nullable<int> fClickRate { get; set; }
        public string fAnnFilePath { get; set; }
    
        public virtual tMemberData tMemberData { get; set; }
    }
}
