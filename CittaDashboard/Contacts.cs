
namespace CittaDashboard
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Contacts
    {
        public int TableId { get; set; }
        [Display(Name = "Add Comments")]
        public string Name { get; set; }
        public Nullable<System.DateTime> Created_at { get; set; }
    }
}