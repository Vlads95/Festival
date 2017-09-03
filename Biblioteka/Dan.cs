using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{

    public enum Vrsta { Exit, SeaDance}
    public class Dan
    {
        Vrsta vrsta;
        DateTime datum;
        int cena;
        int brRasprodatihUlaznica;
        int brProdatih;
      public  List<Izvodjac> spisakIzvodjaca;

        public Dan(Vrsta vrsta,
        DateTime datum,
        int cena,
        int brRasprodatihUlaznica,
        int brProdatih)
        {
            spisakIzvodjaca = new List<Izvodjac>();
            this.vrsta = vrsta;
            this.datum = datum;
            this.cena = cena;
            this.brProdatih = brProdatih;
            this.brRasprodatihUlaznica = brRasprodatihUlaznica;

        }

        public Vrsta Vrsta { get => vrsta; set => vrsta = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public int Cena { get => cena; set => cena = value; }
        public int BrRasprodatihUlaznica { get => brRasprodatihUlaznica; set => brRasprodatihUlaznica = value; }
        public int BrProdatih { get => brProdatih; set => brProdatih = value; }
    }
}
