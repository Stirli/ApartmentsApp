using System.Collections.Generic;

namespace ApartmentApp.Domain.Interfaces
{
    public interface IRepository<T>
    {
        int Count();

        T GetById(int id);
        IEnumerable<T> Take(int size, int? page);
    }
}
