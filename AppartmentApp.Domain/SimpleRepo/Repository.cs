using ApartmentApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApartmentApp.Domain.SimpleRepo
{
    public class Repository : IRepository<Apartment>
    {
        public Repository(int pageSize = 5, IList<Apartment> apartments = null)
        {
            PageSize = pageSize;
            _appartments = apartments ?? new List<Apartment>();
        }

        private readonly IList<Apartment> _appartments;

        public IEnumerable<Apartment> Page(int page)
        {
            return _appartments.Skip(PageSize * (page - 1)).Take(PageSize);
        }

        public int PageSize { get; set; }

        public int Count => _appartments.Count;

        public Apartment this[int index] => _appartments.FirstOrDefault(a => a.Id == index);


       
    }

}
