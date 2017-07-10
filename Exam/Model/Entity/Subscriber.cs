using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Model.Entity
{
    public class Subscriber
    {
        [Key]
        public int SubscriberId { get; set; }

        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string PassportNumber{ get; set; }
        public string Address{ get; set; }
        //
        public ICollection<SubscriberService> SubscriberServices{ get; set; }
        public ICollection<Contract> Contracts { get; set; } 
    }
}
