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
    
    public partial class answer_else
    {
        public int id { get; set; }
        public string name { get; set; }
        public int id_question_else { get; set; }
        public int id_user { get; set; }
    
        public virtual question_else question_else { get; set; }
        public virtual user user { get; set; }
    }
}
