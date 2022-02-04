using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent
{
    public class TypeOfCar
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public string LicensePlateNumber { get; set; }
        public int? Year { get; set; }
        public virtual ICollection<CarRentalRecord> CarRentalRecords { get; set; }

        public TypeOfCar()
        {
            CarRentalRecords = new HashSet<CarRentalRecord>();
        }




    }
}
