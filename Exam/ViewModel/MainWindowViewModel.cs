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

        //
        private ObservableCollection<Service> _query = new ObservableCollection<Service>();
        public ObservableCollection<Service> Query
        {
            get
            {
                return _query;

            }
            set
            {
                _query = value;
                RaisePropertyChanged("Query");
            }
        }


        public ObservableCollection<Operator> Operators
        {
            get
            {
                return new ObservableCollection<Operator>(Db.Operators);
            }
        }


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

        private ICommand _sortByTariffPlan;
        public ICommand SortByTariffPlan
        {
            get
            {
                if (_sortByTariffPlan == null)
                {
                    _sortByTariffPlan = new RelayCommand(SortByTariffPlanExecute, SortByTariffPlanCanExecute);
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
        private void SortByTariffPlanExecute()
        {
            var query = (from q in Db.Services
                        select q).AsEnumerable();
            
            Query = new ObservableCollection<Service>(query);
        }

        //private ICommand _getCostService;

        //public ICommand GetCostService
        //{
        //    get
        //    {
        //        if (_getCostService == null)
        //        {
        //           _getCostService = new RelayCommand<string>(GetCostServiceExecute, GetCostServiceCanExecute);
        //        }
        //        return GetCostService;
        //    }
        //}

        //private bool GetCostServiceCanExecute(string s)
        //{
        //    if (Db == null || s == String.Empty)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        //private void GetCostServiceExecute(string ServiceName)
        //{
        //    Query = GetCostServiceMethod(ServiceName);
        //}

        //[SqlProcedure]
        //public static List<Service> GetCostServiceMethod(string ServiceName)
        //{
        //    List<Service> services;

        //    SqlConnection connection = new SqlConnection("Data Source=LHATEPEOPLE-ПК;Initial Catalog=Exam;Integrated Security=True;Pooling=False");
        //    connection.Open();

        //    SqlCommand getCost = connection.CreateCommand();
        //    getCost.CommandText = "select CostAddition from Service where ServiceName ==" + ServiceName;

        //    services = (List<Service>)getCost.ExecuteScalar();
        //    connection.Close();

        //    return services;
        //}
    }
}
