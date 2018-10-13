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
        
        int IRepository<Apartment>.Count()
        {
            return _appartments.Count;
        }

        public Apartment GetById(int id)
        {
            return _appartments.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Apartment> Take(int size, int? page)
        {
            return EnumerateAll().Skip(size * ((page ?? 1) - 1)).Take(size);
        }
    }

}
