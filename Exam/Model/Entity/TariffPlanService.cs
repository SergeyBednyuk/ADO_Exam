using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Model.Entity
{
    public class TariffPlanService
    {
        [Key]
        public int TariffPlanServiceId{ get; set; }

        [ForeignKey("TariffPlan")]
        public int TariffPlanId { get; set; }
        public TariffPlan TariffPlan{ get; set; }

        [ForeignKey("Service")]
        public int ServiceId{ get; set; }
        public Service Service{ get; set; }
    }
}
