using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1521
{
    class Telefon
    {
        public Telefon(string marka,string model,int ram,int arkakamera,int önkamera,int depolama,string yazılım,int çekirdek,int simkart,int sdkart)
        {
            Marka = marka;
            Model = model;
            Ram = ram;
            ArkaKamera = arkakamera;
            ÖnKamera = önkamera;
            Depolama = depolama;
            Yazılım = yazılım;
            Çekirdek = çekirdek;
            SimKart = simkart;
            SdKart = sdkart;
        }

        public string Marka;
        public string Model;
        public int Ram;
        public int ArkaKamera;
        public int ÖnKamera;
        public int Depolama;
        public string Yazılım;
        public int Çekirdek;
        public int SimKart;
        public int SdKart;


        public string MarkaModel
        {
            get { return Marka + " " + Model; }
        }

    }
}
