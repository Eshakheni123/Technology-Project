//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JigneshWebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Message
    {
        public int MessageId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> CarSellDetailId { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Message_Date { get; set; }
    }
}
