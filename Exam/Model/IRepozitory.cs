using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Model
{
    public interface IRepozitory<T> 
        where T : class
    {
        ObservableCollection<T> GetAll();
    }
}
