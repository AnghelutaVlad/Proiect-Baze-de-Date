using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCabinetVeterinar
{
    internal class Consultatie
    {
        public int ID {  get; set; }

        public DateTime DataEfectuare {  get; set; }

        public int AnimalID {  get; set; }

        public int MedicID {  get; set; }

        public int ServiciuID {  get; set; }
    }
}
