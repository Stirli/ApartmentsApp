using System.Collections.Generic;

namespace ApartmentApp.Domain.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<Apartment> EnumerateAll();
        int Count { get; }

        T this[int index] { get; }
    }
}
