using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klase_i_objekti
{
    class Automobil
    {
        string marka;
        string brojSasije;
        int snaga;
        int godinaProizvodnje;

        public string BrojSasije { get => brojSasije; set => brojSasije = value; }
        public int Snaga { get => snaga; set => snaga = value; }
        public int GodinaProizvodnje { get => godinaProizvodnje; set => godinaProizvodnje = value; }

        public void setMarka(string marka)
        {
            this.marka = marka;
        }
        public string getMarka()

        {
            return this.marka;
        }
        public Automobil() { }
        public Automobil(string marka, string brojSasije, int snaga, int godinaProizvodnje)
        {
            this.snaga = snaga;
            this.marka = marka;
            this.godinaProizvodnje = godinaProizvodnje;
            this.brojSasije = brojSasije;
        }

        public override string ToString()
        {
            string ispis = "Marka: " + this.marka +
                "Broj Šasije" + this.snaga + "KS" + "Godina proizvodnje" + this.godinaProizvodnje;
            return ispis;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Automobil automobil = new Automobil();
            
            automobil.setMarka("BMW");
            automobil.Snaga = 10;
            automobil.BrojSasije = "123456ABC";
            automobil.GodinaProizvodnje =2024;
            */
            Automobil automobil = new Automobil("BMW", "123456ABC", 150, 2024);
            Console.WriteLine(automobil.getMarka());
            Console.WriteLine(automobil.Snaga);
            Console.WriteLine(automobil.BrojSasije);
            Console.WriteLine(automobil.GodinaProizvodnje);
            Console.WriteLine(automobil.ToString());

            Console.ReadKey();
        }
    }
}
