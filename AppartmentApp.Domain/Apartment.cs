using System;
using System.ComponentModel.DataAnnotations;

namespace AppartmentApp.Domain
{
    public class Apartment
    {
        public long Id { get; set; }
        public string ImgSrc { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Display(Name = "Количество комнат")]
        public int RoomsCount { get; set; }
        [Display(Name = "Стоимость")]
        public double Cost { get; set; }
    }
}
