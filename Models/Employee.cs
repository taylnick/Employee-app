//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Employee_Manager_App.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using System.Web.UI.WebControls;
    using System.ComponentModel.DataAnnotations;


    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Managers = new HashSet<Manager>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Position { get; set; }
        public int Department { get; set; }
        [DataType(DataType.Date)]
        public System.DateTime Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public bool Status { get; set; }
        public string Shift { get; set; }
        public Nullable<int> Manager { get; set; }
        public byte[] Photo { get; set; }
        public string Fav_Color { get; set; }
        [DisplayName("Department")]
        public virtual Department Department1 { get; set; }
        [DisplayName("Manager")]
        public virtual Manager Manager1 { get; set; }
        [DisplayName("Position")]
        public virtual Position Position1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Manager> Managers { get; set; }
    }
}