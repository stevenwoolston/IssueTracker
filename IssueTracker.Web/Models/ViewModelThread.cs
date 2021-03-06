//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace IssueTracker.Web.Models
{
    public partial class ViewModelThread
    {
        public ViewModelThread()
        {
            this.ViewModelMessage = new HashSet<ViewModelMessage>();
            this.ViewModelThreadAttachment = new HashSet<ViewModelThreadAttachment>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int LastModBy { get; set; }
        public System.DateTime LastModDate { get; set; }
    
        public virtual ICollection<ViewModelMessage> ViewModelMessage { get; set; }
        public virtual ICollection<ViewModelThreadAttachment> ViewModelThreadAttachment { get; set; }
    }
}
