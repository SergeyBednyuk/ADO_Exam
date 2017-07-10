using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Model.Entity;

namespace Exam.Model
{
    public class Repozitory : IRepozitory<Operator>
    {
        private Context _db = new Context();

        public ObservableCollection<Operator> GetAll()
        {
           return  new ObservableCollection<Operator>(_db.Operators);
        }
    }
}
