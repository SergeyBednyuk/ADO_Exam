using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Model.Entity;

namespace Exam.Model
{
    public class ContextInitializer : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            base.Seed(context);

            var operators = new List<Operator>()
            {
                new Operator() {OperatorName = "MTS", OperatorKode = 29, Address = "'г.Минск, пр. Партизанский, 105'"},
                new Operator() {OperatorName = "Velcom", OperatorKode = 33, Address = "г. Минск, ул.К.Либкнехта, 92"},
                 new Operator() {OperatorName = "LIFE", OperatorKode = 25, Address = "г. Минск, ул.Горецкого, 2"},
                  new Operator() {OperatorName = "BILAIN", OperatorKode = 33, Address = "'г. Минск, пр-т Победителей, 65"},
                   new Operator() {OperatorName = "BEST", OperatorKode = 33, Address = "'г. Минск, ул. Одинцова, 20"}
            };
            context.Operators.AddRange(operators);
            context.SaveChanges();

            var tariffPlans = new List<TariffPlan>()
            {
                new TariffPlan() {TariffPlanName = "МТС СМАРТ", SubscriptionFee = 50000, CostOfAColl = 99, CostOfASms = 240, CostOfAInternationalColl = 800},
                new TariffPlan() {TariffPlanName = "Отличный", SubscriptionFee = 39000, CostOfAColl = 150, CostOfASms = 240, CostOfAInternationalColl = 800},
                new TariffPlan() {TariffPlanName = "Onliner", SubscriptionFee = 10000, CostOfAColl = 440, CostOfASms = 240, CostOfAInternationalColl = 960},
                new TariffPlan() {TariffPlanName = "'Легко Сказать", SubscriptionFee = 3000, CostOfAColl = 840, CostOfASms = 290, CostOfAInternationalColl = 800},
                new TariffPlan() {TariffPlanName = "Абсолют", SubscriptionFee = 700000, CostOfAColl = 0, CostOfASms = 0, CostOfAInternationalColl = 0},
                new TariffPlan() {TariffPlanName = "Родной", SubscriptionFee = 3000, CostOfAColl = 520, CostOfASms = 960, CostOfAInternationalColl = 960}
            };
            context.TariffPlans.AddRange(tariffPlans);

            var subscribers = new List<Subscriber>()
            {
                new Subscriber() {FirstName = "Игорь", LastName = "Сидоров", Address = "г. Минск, ул. Солтаса 12-4", PassportNumber = "d44b273e1b0ba95201519d981416dcb7"},
                new Subscriber() {FirstName = "Николай", LastName = "Карпов", Address = "г. Минск, ул. Юбилейная 45-8", PassportNumber = "ad7011fa2b9520897b3a9d92cd198d1a"},
                new Subscriber() {FirstName = "Ляля", LastName = "Тихонович", Address = "г. Минск, ул. Первая 14-4", PassportNumber = "dacc34dec5f61e1e5cadd56802bc8045"},
                new Subscriber() {FirstName = "Александр", LastName = "Лесин", Address = "г. Минск, ул. Пролетарская 15-8'", PassportNumber = "0e206c02dfd7fabc3fa6630d2fff95a4"},
                new Subscriber() {FirstName = "Анна", LastName = "Шевцова", Address = "'г. Минск, ул. Ленина 30-345", PassportNumber = "cc66005a276c5f4730bd04cd77fdc460"},
                new Subscriber() {FirstName = "Павел", LastName = "Тропашко", Address = "г. Минск, ул. Восточная 43-76", PassportNumber = "d3b47abdec6d1393f34dd5f07ae67226"},
                new Subscriber() {FirstName = "Светлана", LastName = "Салопаева", Address = "г. Минск, ул. Озерная 34-123", PassportNumber = "74f5ebbe9942fd59e807f376620e5699"},
                new Subscriber() {FirstName = "Ольга", LastName = "Луговнева", Address = "г. Минск, ул. Промышленная 15-8", PassportNumber = "9d18542d212003ccbb5ba780c50cad5b"},
                new Subscriber() {FirstName = "Артур", LastName = "Сарычев", Address = "г. Минск, ул. Демирова 30-345", PassportNumber = "a640244eec4d11ce2918d3157afe8147"},
                new Subscriber() {FirstName = "Виктор", LastName = "Валуев", Address = "г. Минск, ул. Родниковая 43-76", PassportNumber = "d7b068221c2e5450a7b6e38b589a4ef5"},
                new Subscriber() {FirstName = "Анастасия", LastName = "Голубь", Address = "г. Минск, ул. Одинцова 34-123", PassportNumber = "f2d8fd3f08982a3f140507d2719522da"}
            };
            context.Subscribers.AddRange(subscribers);

            var services = new List<Service>()
            {
                new Service() {ServiceName = "Безлимитный интернет с телефона", AboutService = "Пользуйтесь безлимитным Интернетом со своего мобильного телефона! Общайтесь в социальных сетях, посещайте любимые сайты не думая о стоимости трафика! Будьте онлайн 24 часа с Opera Mini!", SubscriptionFee = 18000, CostAddition = 18000},
                new Service() {ServiceName = "Музыка без границ", AboutService = "Устали искать в интернете нужный музыкальный трек? Хотите получить доступ к лицензионному контенту без регистрации? Воспользуйтесь выгодным предложением для меломанов - подключите услугу «Музыка без границ с Оперой»", SubscriptionFee = 31500, CostAddition = 10500},
                new Service() {ServiceName = "Тонинг", AboutService = "Услуга «ТОНИНГ» представляет собой абонентский сервис, который позволит  вам заменить длинные гудки мелодией, приветствием или другим звуковым сигналом.", SubscriptionFee = 3600, CostAddition = 0},
                new Service() {ServiceName = "Привет", AboutService = "Услуга «Привет» представляет собой абонентский сервис,\n который позволит  вам писать сообщения\n в 2 раза дешевле.", SubscriptionFee = 0, CostAddition = 2000}
            };
            context.Services.AddRange(services);
            context.SaveChanges();

            var contracts = new List<Contract>()
            {
                new Contract() {DateOfConfinement = new DateTime(2014,02,12), ExpirationDate = new DateTime(2017,02,12), OperatorId = 1, TariffPlanId = 1, SubscriberId = 1},
                new Contract() {DateOfConfinement = new DateTime(2014,02,15), ExpirationDate = new DateTime(2017,02,15), OperatorId = 2, TariffPlanId = 2, SubscriberId = 4},
                new Contract() {DateOfConfinement = new DateTime(2014,02,17), ExpirationDate = new DateTime(2017,02,17), OperatorId = 3, TariffPlanId = 4, SubscriberId = 2},
                new Contract() {DateOfConfinement = new DateTime(2014,05,14), ExpirationDate = new DateTime(2017,05,13), OperatorId = 4, TariffPlanId = 6, SubscriberId = 5},
                new Contract() {DateOfConfinement = new DateTime(2014,02,12), ExpirationDate = new DateTime(2017,02,12), OperatorId = 5, TariffPlanId = 3, SubscriberId = 2},
                new Contract() {DateOfConfinement = new DateTime(2014,07,14), ExpirationDate = new DateTime(2017,06,12), OperatorId = 1, TariffPlanId = 6, SubscriberId = 4},
                new Contract() {DateOfConfinement = new DateTime(2013,07,19), ExpirationDate = new DateTime(2017,06,12), OperatorId = 2, TariffPlanId = 6, SubscriberId = 3},
                new Contract() {DateOfConfinement = new DateTime(2014,06,13), ExpirationDate = new DateTime(2017,02,13), OperatorId = 3, TariffPlanId = 1, SubscriberId = 1},
            };
            context.Contracts.AddRange(contracts);
            context.SaveChanges();
        }
    }
}
