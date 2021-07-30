using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Models {
    public class CarRent {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cpf { get; set; }
        public int Telephone  { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public char Payment { get; set; }
        public DateTime Withdrawal { get; set; }
        public DateTime Devolution { get; set; }

    }
}
