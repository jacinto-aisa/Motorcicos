using System;
using System.Collections.Generic;
using System.Text;

namespace GuerraDeBarcos
{   public enum EstadoCasillaBarco { tocado,intacto}
    public class Casilla
    {
        private EstadoCasillaBarco _tipo;
        private int _X;
        private int _Y;

        public Casilla(int _X, int Y, EstadoCasillaBarco _tipo)
        {
            this._X = _X;
            this._Y = Y;
            this._tipo = _tipo;
        }
    }
}
    
