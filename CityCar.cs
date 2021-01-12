using System;
using System.Collections.Generic;
using System.Text;

namespace Mezzi_Di_Trasporto
{
    class CityCar : Automobile
    {
        private int cilindrata;
        private string modello;

        public int Cilindrata { get; set; }
        public string Modello { get; set; }

        public CityCar(int cilindrata, string modello,string targa,string tipo,int capienza) : base(targa,tipo,capienza)
        {
            Modello = modello;
            Cilindrata = cilindrata;
            Targa = targa;
            Tipo = tipo;
            Capienza = capienza;

        }
        public override string ToString()
        {
            return $"La seguente automobile è una {Tipo} modello {Modello} con cilindrata {Cilindrata} e ha la sua targa è: {Targa}";

        }

    }
}
