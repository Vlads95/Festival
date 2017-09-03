using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Bina
    {


        string ime;
        string lokacija;


        public Bina(
           string ime,
        string lokacija 
            )
        {

            this.ime = ime;
            this.lokacija = lokacija;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Lokacija { get => lokacija; set => lokacija = value; }
    }
}
