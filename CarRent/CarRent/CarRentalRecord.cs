using System;

namespace CarRent
{
    public class CarRentalRecord
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime? DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
        public decimal? Cost { get; set; }
        public int? TypeOfCarId { get; set; }
        public virtual TypeOfCar TypeOfCar { get; set; }



    }
}