using System;
using System.Collections.Generic;
using System.Text;

namespace GuerraDeBarcos
{
    public class Flota
    {
        Barco[] barcos = new Barco[10];
        public Flota(Barco[] barcos)
        {
            this.barcos = barcos;
        }
        public Barco Get(int indice)
        {
            return barcos[indice];
        }
    }
}
