using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZadatak3.Models
{
    internal class MeniOcjena
    {
        public int Id { get; set; }
        public decimal OcjenaKvalitete { get; set; }
        public decimal OcjenaKolicine { get; set; }
        public string Komentar {  get; set; }
    }
}
