using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCabinetVeterinar
{
    internal class Serviciu
    {
        public int ServiciuID { get; set; }

        public int CategorieID {  get; set; }

        public string Denumire {  get; set; }

        public string Detalii { get; set; }

        public int Preț { get; set; }
    }
}
