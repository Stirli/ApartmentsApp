using System.Collections.Generic;

namespace AppartmentApp.Domain.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> Page(int page);
        int PageSize { get; set; }
        int Count { get; }

        T this[int index] { get; }
    }
}
