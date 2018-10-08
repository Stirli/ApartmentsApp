using System.Collections.Generic;
using System.Linq;
using ApartmentApp.Domain.Interfaces;

namespace ApartmentApp.Domain.SimpleRepo
{
    public class Repository : IRepository<Apartment>
    {
        public Repository(int pageSize = 5)
        {
            PageSize = pageSize;
            _appartments = new List<Apartment>
            {
                new Apartment
                {
                    Id = 1,
                    Address = "улица Кальварийская, дом 50, кв. 5",
                    RoomsCount = 3,
                    Cost = 10500,
                    ImgSrc = "https://avatars.mds.yandex.net/get-pdb/34158/c1ab4d4a-436e-480b-9545-db39c07640d8/s1200?webp=false"
                },
                new Apartment
                {
                    Id = 2,
                    Address = "улица Болотная, дом 21",
                    RoomsCount = 7,
                    Cost = 10500500,
                    ImgSrc = "https://avatars.mds.yandex.net/get-pdb/199965/5f3ac1be-850e-49ee-b365-1fb151c69d8e/s1200?webp=false"
                },
                new Apartment
                {
                    Id = 3,
                    Address = "переулок Загадочный, дом 165, кв. 35",
                    RoomsCount = 1,
                    Cost = 10500500,
                    ImgSrc = "https://million-wallpapers.ru/wallpapers/4/96/16367173929673215102.jpg"
                },
                new Apartment
                {
                    Id = 4,
                    Address = "Короля д. 47 кв. 2",
                    RoomsCount = 3,
                    Cost = 123456,
                    ImgSrc = "https://avatars.mds.yandex.net/get-pdb/25978/4f9a8a81-55e5-4f32-8449-098f0f78a627/s1200?webp=false"
                },
                new Apartment
                {
                    Id = 5,
                    Address = "Немига д. 10 кв. 28",
                    RoomsCount = 2,
                    Cost = 315479,
                    ImgSrc = "http://svoimy-rukami.ru/wp-content/uploads/2017/03/Квартира-в-современном-стиле-24.jpg"
                },
                new Apartment
                {
                    Id = 6,
                    Address = "Гебелева улица д. 6/2 кв. 6",
                    RoomsCount = 3,
                    Cost = 4235789,
                    ImgSrc = "https://million-wallpapers.ru/wallpapers/2/1/425821750047256.jpg"
                },
                new Apartment
                {
                    Id = 7,
                    Address = "Романовская Слобода д. 7 кв. 40",
                    RoomsCount = 4,
                    Cost = 7862123,
                    ImgSrc = "https://3qz.info/wp-content/uploads/interyer-kvartiry-v-eko-stile-08.jpg"
                },
            };
        }

        private readonly List<Apartment> _appartments;

        public IEnumerable<Apartment> Page(int page)
        {
            return _appartments.Skip(PageSize * (page - 1)).Take(PageSize);
        }

        public int PageSize { get; set; }

        public int Count => _appartments.Count;

        public Apartment this[int index] => _appartments.Find(a => a.Id == index);
    }
}
