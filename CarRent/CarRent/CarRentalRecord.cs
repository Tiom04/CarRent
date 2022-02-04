using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRent
{
    public class CarRentalRecord
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime? DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
        public decimal? Cost { get; set; }
        public int? TypeOfCarId { get; set; }
        public virtual TypeOfCar TypeOfCar { get; set; }



    }
}