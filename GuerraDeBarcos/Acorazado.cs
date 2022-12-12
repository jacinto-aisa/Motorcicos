using System;
using System.Collections.Generic;
using System.Text;

namespace GuerraDeBarcos
{
    public class Acorazado : Barco
    {
        public Acorazado(int x, int y, posicion _pos) : base(x, y, _pos, 2)
        {

        }
    }
}
