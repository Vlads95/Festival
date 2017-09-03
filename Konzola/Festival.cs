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
                    if (i.zemlja != "Srbija" && !lista.Contains(i.Bina))
                    {
                        lista.Add(i.Bina);
                    }

                }
            }



            return lista; 
        }



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


        static void Main(string[] args)
        {



        }
    }
}
