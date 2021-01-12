using System;
using System.Collections.Generic;
using System.Text;

namespace Mezzi_Di_Trasporto
{
    class Bicicletta : MezziDiTrasporto
    {
        private string modello;
        public string Modello { get; set; }

        public Bicicletta(string tipo,string modello,int capienza)
        {
            Capienza = capienza;
            Tipo = tipo;
            Modello = modello;
        }
        public override string ToString()
        {
            return $"Il modello della bicicletta è: {Modello} di tipo {Tipo} con la capienza di {Capienza}";
        }
    }
}
