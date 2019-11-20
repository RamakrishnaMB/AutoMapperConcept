using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class FeeDetails 
    {
        public byte StandardID { get; set; }
        public Nullable<int> KanNoOfStudents { get; set; }
        public Nullable<int> EngNoOfStudents { get; set; }
        public Nullable<int> KanPaidStudCount { get; set; }
        public Nullable<int> KanDueStudCount { get; set; }
        public Nullable<int> EngPaidStudCount { get; set; }
        public Nullable<int> EngDueStudCount { get; set; }
    }
}
