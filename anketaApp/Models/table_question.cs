//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace anketaApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class table_question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public table_question()
        {
            this.answer_table = new HashSet<answer_table>();
        }
    
        public int id { get; set; }
        public int number { get; set; }
        public string name { get; set; }
        public int id_question { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<answer_table> answer_table { get; set; }
        public virtual question question { get; set; }
    }
}
