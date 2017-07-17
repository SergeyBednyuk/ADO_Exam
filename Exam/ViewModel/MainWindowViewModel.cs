using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;
using Exam.Model;
using Exam.Model.Entity;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.SqlServer.Server;

namespace Exam.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private Context _db;
        //Connect to DB
        public Context Db
        {
            get
            {
                if (_db == null)
                {
                    _db = new Context();
                }
                return _db;
            }
        }

        #region First query
        private ObservableCollection<Service> _querySortByTariffPlane = new ObservableCollection<Service>();
        public ObservableCollection<Service> QuerySortByTariffPlane
        {
            get
            {
                return _querySortByTariffPlane;

            }
            set
            {
                _querySortByTariffPlane = value;
                RaisePropertyChanged("QuerySortByTariffPlane");
            }
        }
        private ICommand _sortByTariffPlan;
        public ICommand SortByTariffPlan
        {
            get
            {
                if (_sortByTariffPlan == null)
                {
                    _sortByTariffPlan = new RelayCommand(SortByTariffPlanExecuteAsync, SortByTariffPlanCanExecute);
                }
                return _sortByTariffPlan;
            }
        }
        private bool SortByTariffPlanCanExecute()
        {
            if (Db == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private async void SortByTariffPlanExecuteAsync()
        {
            var query = await Task.Run(() =>
            {
                var queryToDb = from q in Db.Services
                                select q;
                return queryToDb;
            });


            QuerySortByTariffPlane = new ObservableCollection<Service>(query);
        }


        #endregion

        #region Second query

        private ObservableCollection<Service> _queryGetServicesTheSecondTariffPlane;
        public ObservableCollection<Service> QueryGetServicesTheSecondTariffPlane
        {
            get
            {
                return _queryGetServicesTheSecondTariffPlane;
            }
            set
            {
                _queryGetServicesTheSecondTariffPlane = value;
                RaisePropertyChanged("QueryGetServicesTheSecondTariffPlane");
            }

        }

        private ICommand _getServicesTheSecondTariffPlane;

        public ICommand GetServicesTheSecondTariffPlane
        {
            get
            {
                if (_getServicesTheSecondTariffPlane == null)
                {
                    _getServicesTheSecondTariffPlane = new RelayCommand(GetServicesTheSecondTariffPlaneExecuteAsync, GetServicesTheSecondTariffPlaneCenExecute);
                }
                return _getServicesTheSecondTariffPlane;
            }

        }

        private bool GetServicesTheSecondTariffPlaneCenExecute()
        {
            if (_db == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private async void GetServicesTheSecondTariffPlaneExecuteAsync()
        {
            var query = await Task.Run(() =>
            {
                var queryToDb = from q in Db.TariffPlans
                                where q.TariffPlanId == 2
                                select q.Services;
                return queryToDb;
            });
            //TODO Type convert
            //QueryGetServicesTheSecondTariffPlane = new ObservableCollection<Service>(query);

        }

        #endregion

        #region Third query

        private ObservableCollection<Contract> _queryGetContractsInThisMonth;
        public ObservableCollection<Contract> QueryGetContractsInThisMonth
        {
            get
            {
                return _queryGetContractsInThisMonth;
            }
            set
            {
                _queryGetContractsInThisMonth = value;
                RaisePropertyChanged("QueryGetContractsInThisMonth");
            }
        }

        private ICommand _getContractsInThiseMonth;

        public ICommand GetContractsInThiseMonth
        {
            get
            {
                if (_getContractsInThiseMonth == null)
                {
                    _getContractsInThiseMonth = new RelayCommand(GetContractsInThisMonthExecuteAsync, GetContractsInThisMonthCanExecute);
                }
                return _getContractsInThiseMonth;
            }
        }

        private bool GetContractsInThisMonthCanExecute()
        {
            if (Db == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private async void GetContractsInThisMonthExecuteAsync()
        {
            var query = await Task.Run(() =>
            {
                var queryToDb = from q in Db.Contracts
                                where q.DateOfConfinement == new DateTime(2014, 07, 14)
                                select q;
                return queryToDb;
            });

            QueryGetContractsInThisMonth = new ObservableCollection<Contract>(query);
        }

        #endregion

        #region Fourth query

        private ObservableCollection<TariffPlan> _queryGetInfoAboutSmart;
        public ObservableCollection<TariffPlan> QueryGetInfoAboutSmart
        {
            get
            {
                return _queryGetInfoAboutSmart;
            }
            set
            {
                _queryGetInfoAboutSmart = value;
                RaisePropertyChanged("QueryGetInfoAboutSmart");
            }
        }

        private ICommand _getInfoAboutSmart;

        public ICommand GetInfoAboutSmart
        {
            get
            {
                if (_getInfoAboutSmart == null)
                {
                    _getInfoAboutSmart = new RelayCommand(GetInfoAboutSmartExecuteAsync, GetInfoAboutSmartCanExecute);
                }
                return _getInfoAboutSmart;
            }
        }

        private bool GetInfoAboutSmartCanExecute()
        {
            if (Db == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private async void GetInfoAboutSmartExecuteAsync()
        {
            var query = await Task.Run(() =>
            {
                var queryToDb = from q in Db.TariffPlans
                where q.TariffPlanName == "МТС СМАРТ"
                select q;
                return queryToDb;
            });
            QueryGetInfoAboutSmart = new ObservableCollection<TariffPlan>(query);
        }

        #endregion

        #region Fifth query



        #endregion

        public ObservableCollection<Operator> Operators
        {
            get
            {
                return new ObservableCollection<Operator>(Db.Operators);
            }
        }

        #region Task Four

        private ObservableCollection<Service> _getInfoAboutService;

        public ObservableCollection<Service> GetInfoAboutService
        {
            get
            {
                return _getInfoAboutService;
            }
            set
            {
                _getInfoAboutService = value;
                RaisePropertyChanged("GetInfoAboutService");
            }
        }

        private ICommand _getCostService;

        public ICommand GetCostService
        {
            get
            {
                if (_getCostService == null)
                {
                    _getCostService = new RelayCommand<string>(GetCostServiceExecute, GetCostServiceCanExecute);
                }
                return _getCostService;
            }
        }

        private bool GetCostServiceCanExecute(string s)
        {
            if (Db == null || s == String.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void GetCostServiceExecute(string ServiceName)
        {
            QuerySortByTariffPlane = GetCostServiceMethod(ServiceName);
        }

        [SqlProcedure]
        public static ObservableCollection<Service> GetCostServiceMethod(string ServiceName)
        {
            SqlConnection connection = new SqlConnection("Data Source=LHATEPEOPLE-ПК;Initial Catalog=Exam;Integrated Security=True;Pooling=False");
            connection.Open();

            SqlCommand getCost = connection.CreateCommand();
            getCost.CommandText = "select * from Service where ServiceName ==" + ServiceName;

            var services = (ObservableCollection<Service>)getCost.ExecuteScalar();
            connection.Close();

            return services;
        }

        #endregion


    }
}
