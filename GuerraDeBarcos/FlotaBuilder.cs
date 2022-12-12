using System;
using System.Collections.Generic;
using System.Text;

namespace GuerraDeBarcos
{
    public class FlotaBuilder : IFlotaBuilder
    {
        Barco[] arrayBarcos = new Barco[10];
        public Barco[] dameFlota()
        {
            arrayBarcos[0] = new Submarino(5, 4);
            arrayBarcos[1] = new Submarino(6, 2);
            arrayBarcos[2] = new Submarino(9, 4);
            arrayBarcos[3] = new Submarino(1, 4);
            arrayBarcos[4] = new Acorazado(10, 4, posicion.vertical);
            arrayBarcos[5] = new Acorazado(6, 2, posicion.horizontal);
            arrayBarcos[6] = new Acorazado(9, 4, posicion.vertical);
            arrayBarcos[7] = new Destructor(4, 1, posicion.horizontal);
            arrayBarcos[8] = new Destructor(4, 1, posicion.horizontal);
            arrayBarcos[9] = new Portaaviones(5, 4, posicion.horizontal);
            return arrayBarcos;
        }
    }
    

}
