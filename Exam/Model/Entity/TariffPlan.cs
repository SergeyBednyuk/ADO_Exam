using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Model.Entity
{
    public class TariffPlan
    {
        [Key]
        public int TariffPlanId{ get; set; }

        public string TariffPlanName { get; set; }
        public double SubscriptionFee { get; set; }
        public double CostOfAColl{ get; set; }
        public double CostOfASms{ get; set; }
        public double CostOfAInternationalColl{ get; set; }
        //
        public ICollection<Contract> Contracts { get; set; }
        public ICollection<TariffPlanService> Services { get; set; } 
    }
}
