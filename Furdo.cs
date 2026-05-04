using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrandC
{
    public class Furdo
    {
        public String Név { get; private set; }
        public String Cím { get; private set; }
        public int Ár { get; private set; }
        public int Vízhőfok { get; private set; }


        //Gyulai Várfürdő;5700 Gyula, Várfürdő u. 1.;6000;36
        public Furdo(String sor)
        {
            string[] adatok=sor.Split(";");
            Név=adatok[0];
            Cím = adatok[1];
            Ár=int.Parse(adatok[2]);
            Vízhőfok=int.Parse(adatok[3]);
        }

        public String IRSZ()
        {
            //5700 Gyula, Várfürdő u. 1.
            return Cím.Split(" ")[0];  
        }
        public String Telepules()
        {
            //5700 Gyula, Várfürdő u. 1.
            return Cím.Split(" ")[1].Split(",")[0];//
        }
    }
}
