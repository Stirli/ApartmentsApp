using System.Collections.Generic;

namespace ApartmentApp.Domain.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> EnumerateAll();
        int Count { get; }

        T this[int index] { get; }
        IEnumerable<T> Take(int size, int? page);
    }
}
