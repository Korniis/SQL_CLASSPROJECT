//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sports
{
    using System;
    using System.Collections.Generic;
    
    public partial class RegistrationTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RegistrationTable()
        {
            this.AthleteTable = new HashSet<AthleteTable>();
        }
    
        public int SNO { get; set; }
        public string Name { get; set; }
        public int AthleteID { get; set; }
        public string Gender { get; set; }
        public int ClassID { get; set; }
        public Nullable<System.DateTime> RegistrationTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AthleteTable> AthleteTable { get; set; }
        public virtual ClassTable ClassTable { get; set; }
    }
}
