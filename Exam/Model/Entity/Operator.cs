using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Model.Entity
{
    public class Operator
    {
        [Key]
        public int OperatorId { get; set; }
        public string OperatorName{ get; set; }
        public int OperatorKode { get; set; }
        public string Address { get; set; }
        //
        public ICollection<Contract> Contracts { get; set; } 
    }
}
