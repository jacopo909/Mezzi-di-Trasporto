using System;
using System.Collections.Generic;
using System.Text;

namespace Mezzi_Di_Trasporto
{
    abstract class Automobile : MezziDiTrasporto
    {
        private string targa;
       
        public string Targa { get; set; }
        

        public Automobile(string targa, string tipo,int capienza) { }
    }
}
