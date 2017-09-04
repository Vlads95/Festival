using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteka;
namespace Konzola
{
    class Festival
    {


        int godina;
        List<PotencijalniIzvodjac> listaPotencijalnih;
        List<Dan> programPoDanima;


        public Festival(int godina)
        {
            this.godina = godina;
            listaPotencijalnih = new List<PotencijalniIzvodjac>();
            programPoDanima = new List<Dan>();
        }

        public int Godina { get => godina; set => godina = value; }
        public List<PotencijalniIzvodjac> ListaPotencijalnih { get => listaPotencijalnih; set => listaPotencijalnih = value; }
        public List<Dan> ProgramPoDanima { get => programPoDanima; set => programPoDanima = value; }





        //bine sa domacim izvodjacima 

           public List<Bina> bineDomace()
        {

            List<Bina> lista = new List<Bina>();


            foreach (Dan d in programPoDanima)
            {



                foreach (Izvodjac i in d.spisakIzvodjaca)
                {
                    if (i.zemlja == "Srbija" && !lista.Contains(i.Bina))
                    {
                        lista.Add(i.Bina);
                    }

                }
            }



            return lista; 
        }




        //List<Bina> domacaBina()
        //{
        //    List<Bina> binice = new List<Bina>();
        //    List<Bina> domaceBinice = new List<Bina>();
        //    foreach (Dan d in programPoDanima)
        //    {
        //        foreach (Izvodjac i in d.SpisakIzvodjaca)
        //        {
        //            if (!binice.Contains(i.Bina))
        //            {
        //                binice.Add(i.Bina);
        //            }
        //        }
        //    }

        //    foreach (Bina b in binice)
        //    {
        //        Boolean srbin = true;
        //        foreach (Dan d in programPoDanima)
        //        {
        //            foreach (Izvodjac i in d.SpisakIzvodjaca)
        //            {
        //                if (b.Naziv == i.Bina.Naziv)
        //                {
        //                    if (i.Zemlja == "Srbija")
        //                    {
        //                        if (srbin == false)
        //                        {
        //                            break;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        if (srbin == true)
        //        {
        //            if (!domaceBinice.Contains(b))
        //            {
        //                domaceBinice.Add(b);
        //            }
        //        }
        //    }


        //    return domaceBinice;
        //}






        /*
         
             List<Bina> lista = new List<Bina>();


            foreach (Dan d in programPoDanima)
            {

                foreach (Izvodjac i in d.spisakIzvodjaca)
                {
                    

                }
            }



            return lista;  
             
             
             */




        //13. najskuplji izvodjac  ili izvodjaci na zadatoj vrsti festivala 
        public Izvodjac najskupljiIzvodjac (Vrsta vr)
        {

            //List<Bina> lista = new List<Bina>();

            double max = 0;
            Izvodjac maxIzvodjac = null;

            foreach (Dan d in programPoDanima)
            {

                if (d.Vrsta==vr)
                {
                    foreach (Izvodjac i in d.spisakIzvodjaca)
                    {




                        foreach (Dan d1 in programPoDanima)
                        {

                            foreach (Izvodjac i1 in d1.spisakIzvodjaca)
                            {
                                if (i.honorar > i1.honorar)
                                {
                                    max = i.honorar;
                                    maxIzvodjac = i;
                                }
                            }
                        }

                    } 
                }
            }



            return maxIzvodjac;


        }

        //7. prosecno trajanje nastupa na odredjenoj bini 

             public double prosecnoTrajanje (Bina b)
        {

            int br = 0;
            int tr = 0;

            foreach (Dan d in programPoDanima)
            {

                foreach (Izvodjac i in d.spisakIzvodjaca)
                {

                    if (i.bina==b)
                    {
                        br++;
                        tr += i.trajanjeNastupa;
                    }
                }
            }



            return tr/br;



        }


        //1. ZEMLJE IZ KOJIH DOLAZE STRANI IZVODJACI KOJI NASTUPAJU ODREDJEN0G DATUMA NA ODREDJENOJ BINI NA EXITU

            public List<string>  zemljeStranaca(DateTime datum , Bina bina )
        {

            List<string> lista = new List<string>();


            foreach (Dan d in programPoDanima)
            {

                if (d.Vrsta==Vrsta.Exit)
                {
                    foreach (Izvodjac i in d.spisakIzvodjaca)
                    {

                    }
                }
            }



            return lista;


        }



        // 2. nazivi i kontakt telefoni pot. izvodjaca koji nisu odgovorili a poziv im je upucen pre vise od mesec dana 
        public List<string> nazivBrojTel()
        {
            List<string> lista = new List<string>();
            foreach (PotencijalniIzvodjac p in listaPotencijalnih)
            {

                if (p.Status==Status.NijeOdgovorio && (DateTime.Now- p.datumPoziva).TotalDays >30)
                {
                    lista.Add(p.naziv + "," + p.telefon);
                }


            }

            return lista;
        }



        //8. 
        public List<Izvodjac> izvodjaciSaRazlicitimHonorarom()
        {

            List<Izvodjac> lista = new List<Izvodjac>();


            foreach (Dan d in programPoDanima)
            {

                foreach (Izvodjac i in d.spisakIzvodjaca)
                {


                }
            }



            return lista;

        }


        //19. vreme pocetka prvog nastupa i vreme zavrsetka poslednjeg nastupa idredheog datuma na odredjenoj bini 


        public DateTime najkasniji(Bina bina)
        {
            DateTime n = DateTime.MinValue;
            foreach (Dan d in programPoDanima)
            {
                foreach (Izvodjac i in d.spisakIzvodjaca)
                {
                    if (i.Vreme.AddMinutes(i.TrajanjeNastupa) > n)
                    {
                        n = i.Vreme.AddMinutes(i.TrajanjeNastupa);
                    }
                } 
            }
            return n;
        }



        public DateTime[] vremePocetkaIZavrsetka(DateTime datum, Bina bina)
        {

            DateTime prvi = DateTime.MinValue;
            DateTime zadnji = DateTime.MaxValue;

            foreach (Dan d in programPoDanima)
            {
                if (d.Datum==datum)
                {

                }
            }

            return null;
        }




        //18. 

        public string metoda18(Vrsta v)
        {
            List<DateTime> datumi = new List<DateTime>();
            List<double> cene = new List<double>();
            string rez = "";

            foreach (Dan d in programPoDanima)
            {
                if (d.Vrsta == v && !datumi.Contains(d.Datum))
                {
                    datumi.Add(d.Datum);
                }
            }

            for (int i = 0; i < datumi.Count; i++)
            {
                for (int j = 0; j < datumi.Count; j++)
                {
                    if (datumi[i] > datumi[j])
                    {
                        DateTime pom = datumi[i];
                        datumi[i] = datumi[j];
                        datumi[j] = pom;
                    }
                }
            }

            foreach (DateTime d in datumi)
            {
                foreach (Dan da in programPoDanima)
                {
                    if (d == da.Datum)
                    {
                        cene.Add(da.Cena);
                    }
                }
            }
            bool rastuce = false;

            for (int i = 0; i < cene.Count - 1; i++)
            {

                if (cene[i] <= cene[i + 1])
                {
                    rastuce = true;
                }
                else
                {
                    rastuce = false;
                    break;
                }
            }
            if (rastuce == true) return rez = "rastuce";

            bool opadajuce = false;
            for (int i = 0; i < cene.Count - 1; i++)
            {

                if (cene[i] >= cene[i + 1])
                {
                    opadajuce = true;
                }
                else
                {
                    opadajuce = false;
                    break;
                }
            }
            if (opadajuce == true)
            {
                return rez = "opadajuce";
            }
            else
            {
                return rez = "varira";
            }
        }



        //19

        public string metoda19(DateTime dat, Bina bin)
        {

            DateTime min = DateTime.MaxValue;
            DateTime max = DateTime.MinValue;
            int trajanjePoslednjeg = 0;

            foreach (Dan d in programPoDanima)
            {
                if (d.Datum == dat)
                {
                    foreach (Izvodjac i in d.spisakIzvodjaca)
                    {
                        if (i.Bina.Ime == bin.Ime && i.vreme < min)
                        {
                            min = i.vreme;
                        }
                    }
                }
            }

            foreach (Dan d in programPoDanima)
            {
                if (d.Datum == dat)
                {
                    foreach (Izvodjac i in d.spisakIzvodjaca)
                    {
                        if (i.Bina.Ime == bin.Ime && i.vreme > max)
                        {
                            max = i.vreme;
                            trajanjePoslednjeg = i.TrajanjeNastupa;
                        }
                    }
                }
            }

            return string.Format("{0},{1}", min, max.AddMinutes(trajanjePoslednjeg));
        }


        //20. 

        public string metoda20()
        {
            string rez = "";
            List<DateTime> datumi = new List<DateTime>();

            foreach (Dan d in programPoDanima)
            {
                if (!datumi.Contains(d.Datum)) datumi.Add(d.Datum);
            }

            for (int i = 0; i < datumi.Count; i++)
            {
                for (int j = 0; j < datumi.Count; j++)
                {
                    if (datumi[i] > datumi[j])
                    {
                        DateTime pom = datumi[i];
                        datumi[i] = datumi[j];
                        datumi[j] = pom;
                    }
                }
            }

            foreach (DateTime a in datumi)
            {
                int dan = 1;
                foreach (Dan d in programPoDanima)
                {
                    if (a == d.Datum && d.Vrsta == Vrsta.Exit)
                    {
                        rez += string.Format("Dan broj: {0}. Datum: {1}. Izvodjaci:", dan, d.Datum);
                        foreach (Izvodjac i in d.spisakIzvodjaca)
                        {
                            rez += string.Format("{0}", i.Naziv);
                        }

                    }
                }
                dan++;
            }

            foreach (DateTime a in datumi)
            {
                int dan = 1;
                foreach (Dan d in programPoDanima)
                {
                    if (a == d.Datum && d.Vrsta == Vrsta.SeaDance)
                    {
                        rez += string.Format("Dan broj: {0}. Datum: {1}. Izvodjaci:", dan, d.Datum);
                        foreach (Izvodjac i in d.spisakIzvodjaca)
                        {
                            rez += string.Format("{0}", i.Naziv);
                        }

                    }
                }
                dan++;
            }
            return rez;

        }




        static void Main(string[] args)
        {



        }
    }
}
