//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_BriefAnswerSheet
    {
        public T_BriefAnswerSheet()
        {
            this.T_BriefScore = new HashSet<T_BriefScore>();
        }
    
        public int ID { get; set; }
        public int AnswerSheetID { get; set; }
        public int QuestionID { get; set; }
        public string Answer { get; set; }
    
        public virtual T_AnswerSheet T_AnswerSheet { get; set; }
        public virtual T_Question T_Question { get; set; }
        public virtual ICollection<T_BriefScore> T_BriefScore { get; set; }
    }
}
