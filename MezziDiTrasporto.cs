using System;

namespace Mezzi_Di_Trasporto
{
    abstract class MezziDiTrasporto
    {
        private int capienza;
        private  string tipo;
        
        public string Tipo { get; set; }
        public int Capienza { get; set; }
        public abstract string ToString();
        

    }
}
