using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Izvodjac:PotencijalniIzvodjac
    {

        public  DateTime vreme;
        public int trajanjeNastupa;
        public Bina bina;
        public double honorar;

        public Izvodjac(DateTime vreme,
        int trajanjeNastupa,
        Bina bina,
        double honorar, string naziv,
        string zemlja,
        string telefon,
        DateTime datumPoziva,
        Status status) :base(naziv,zemlja,telefon,datumPoziva,status)
        {
            this.vreme = vreme;
            this.trajanjeNastupa = trajanjeNastupa;
            this.bina = bina;
            this.honorar = honorar;
        }

        public DateTime Vreme { get => vreme; set => vreme = value; }
        public int TrajanjeNastupa { get => trajanjeNastupa; set => trajanjeNastupa = value; }
        public Bina Bina { get => bina; set => bina = value; }
        public double Honorar { get => honorar; set => honorar = value; }




        public bool  daLiJeStranac ()
        {
            if (Zemlja.Equals("SRB"))
                return false;
            return true;

        }



    }
}
