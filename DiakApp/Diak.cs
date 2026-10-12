using System;
using System.Collections.Generic;
using System.Text;

namespace DiakApp
{
    public class Diak
    {
        string Nev { get; set; }
        string Osztaly { get; set; }
        private int pontszam { get; set; }
        public int Pontszam 
        {
            get { return pontszam; }
            set
            {
                if (value < 0)
                {
                    pontszam = 0;
                }
                else if(value > 100)
                {
                    pontszam = 100;
                }
            }
        }
    }
}
