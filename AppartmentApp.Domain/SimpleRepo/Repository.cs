using ApartmentApp.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ApartmentApp.Domain.SimpleRepo
{
    public class Repository : IRepository<Apartment>
    {
        public Repository(ICollection<Apartment> apartments = null)
        {
            _appartments = apartments ?? new List<Apartment>();
        }

        private readonly ICollection<Apartment> _appartments;
        
        public IEnumerable<Apartment> EnumerateAll()
        {
            return _appartments;
        }
        public int Count => _appartments.Count;

        public Apartment this[int index] => _appartments.FirstOrDefault(a => a.Id == index);

        public IEnumerable<Apartment> Take(int size, int? page)
        {
            return EnumerateAll().Skip(size * ((page ?? 1) - 1)).Take(size);
        }
    }

}
