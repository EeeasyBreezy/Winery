using System.Collections.Generic;

namespace Winery.DataBaseManagers
{
    interface IDbManagable<T>
    {
        List<T> GetData();
        void LoadData(T data);
        void EditData(T data);
        void DeleteData(int id);
    }
}
