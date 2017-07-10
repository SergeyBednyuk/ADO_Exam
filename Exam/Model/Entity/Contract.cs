using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Model.Entity
{
    public class Contract
    {
        [Key]
        public int ContractId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime DateOfConfinement { get; set; }
        //
        [ForeignKey("Operator")]
        public int OperatorId { get; set; }
        public Operator Operator { get; set; }

        [ForeignKey("Subscriber")]
        public int SubscriberId { get; set; }
        public Subscriber Subscriber { get; set; }

        [ForeignKey("TariffPlan")]
        public int TariffPlanId { get; set; }
        public TariffPlan TariffPlan { get; set; }
    }
}
