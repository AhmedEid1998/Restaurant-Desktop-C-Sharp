//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class userpermission
    {
        public int permission_id { get; set; }
        public string main_screen { get; set; }
        public string permission { get; set; }
        public Nullable<int> userid { get; set; }
        public Nullable<bool> @case { get; set; }
    }
}