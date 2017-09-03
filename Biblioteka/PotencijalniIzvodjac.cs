using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public enum Status { NijePrihvatio, NijeOdgovorio}
    public class PotencijalniIzvodjac
    {

        public string naziv;
       public string zemlja;
        public string telefon;
        public  DateTime datumPoziva;
        Status status;

        public PotencijalniIzvodjac(
            string naziv,
        string zemlja,
        string telefon,
        DateTime datumPoziva,
        Status status      )
        {
            this.naziv = naziv;
            this.zemlja = zemlja;
            this.telefon = telefon;
            this.datumPoziva = datumPoziva;
            this.status = Status;

        }

        public string Naziv { get => naziv; set => naziv = value; }
        public string Zemlja { get => zemlja; set => zemlja = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public DateTime DatumPoziva { get => datumPoziva; set => datumPoziva = value; }
        public Status Status { get => status; set => status = value; }
    }
}
