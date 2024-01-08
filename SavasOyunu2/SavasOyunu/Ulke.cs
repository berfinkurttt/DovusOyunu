using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SavasOyunu
{
    public class Ulke
    {

        private string _UlkeAd;
        private int _UlkeHasar;
        private int _Can = 100;

        Random random = new Random();

        public string UlkeAd
        {
            get { return _UlkeAd; }
            set { _UlkeAd = value; }
        }

        public int UlkeHasar
        {
          
            get {  return random.Next(1, 26); }
            set { _UlkeHasar = value; }
        }
        public int Can

        {
            get { return _Can; }
            set { _Can = value; }
        }

        public int hasar()
        {
            
            _UlkeHasar = UlkeHasar;
            return _UlkeHasar;
        }

        //public int aldıgıhasar(int deger)
        //{
        //    deger -= _Can;
        //    return deger;

        //}
    }
}
