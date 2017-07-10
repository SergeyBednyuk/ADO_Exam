using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Model.Entity
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }

        public string ServiceName { get; set; }
        public string AboutService{ get; set; }
        public double CostAddition { get; set; }
        public double SubscriptionFee{ get; set; }
        //
        public ICollection<SubscriberService> SubscriberServices{ get; set; }
        public ICollection<TariffPlanService> TariffPlanServices { get; set; } 
    }
}
