//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IssueTracker.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public Message()
        {
            this.MessageAttachment = new HashSet<MessageAttachment>();
        }
    
        public int Id { get; set; }
        public int ThreadId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int LastModBy { get; set; }
        public System.DateTime LastModDate { get; set; }
    
        public virtual Thread Thread { get; set; }
        public virtual ICollection<MessageAttachment> MessageAttachment { get; set; }
    }
}
