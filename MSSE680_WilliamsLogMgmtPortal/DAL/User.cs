//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSSE680_WilliamsLogMgmtPortal.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int OrganizationId { get; set; }
        public bool AdminFlag { get; set; }
        public System.DateTime ActiveDate { get; set; }
        public Nullable<System.DateTime> InactiveDate { get; set; }
    
        public virtual Organization Organization { get; set; }
    }
}
