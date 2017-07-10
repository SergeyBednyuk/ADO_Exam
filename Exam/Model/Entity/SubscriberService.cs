using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Model.Entity
{
    public class SubscriberService
    {
        [Key]
        public int SubscriberServiceId { get; set; }
        //
        [ForeignKey("Subscriber")]
        public int SubscriberId { get; set; }
        public Subscriber Subscriber{ get; set; }

        [ForeignKey("Service")]
        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
