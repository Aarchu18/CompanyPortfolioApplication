//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPortfolioDetail
    {
        public int PortfolioID { get; set; }
        public string PortfolioName { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string PortfolioDescription { get; set; }
        public string CoverImage { get; set; }
        public string YouTubeUrl { get; set; }
    
        public virtual tblCompanyDetail tblCompanyDetail { get; set; }
    }
}
