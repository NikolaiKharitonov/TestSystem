//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testSustem.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Answer
    {
        public int AnswerID { get; set; }
        public string Content { get; set; }
        public Nullable<int> QuestionID { get; set; }
        public Nullable<bool> Right { get; set; }
    
        public virtual Question Question { get; set; }
    }
}
