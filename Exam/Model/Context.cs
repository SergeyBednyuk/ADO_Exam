using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Model.Entity;

namespace Exam.Model
{
    public class Context : DbContext
    {
        public Context()
            : base("DbContext")
        { }

        static Context()
        {
            System.Data.Entity.Database.SetInitializer(new ContextInitializer());
        }

        public DbSet<Operator> Operators { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<SubscriberService> SubscriberServices { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<TariffPlan> TariffPlans { get; set; }
        public DbSet<TariffPlanService> TariffPlanServices { get; set; }

    }
}
