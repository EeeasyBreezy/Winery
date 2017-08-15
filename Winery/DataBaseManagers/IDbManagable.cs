using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winery.DataBaseManagers
{
    interface IDbManagable<T>
    {
        List<T> GetData();
        void LoadData(T data);
        void EditData(T data);
        void DeleteData(T data);
    }
}
