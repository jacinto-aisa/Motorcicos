using System;
using System.Collections.Generic;
using System.Text;

namespace GuerraDeBarcos
{
    public class Barco
    {
        Casilla[] casillas;
        int puntos;
        public Barco(int x, int y, posicion _posicion, int longitud)
        {
            this.puntos = longitud;
            if (longitud == 1)
            {
                Casilla[] casillas = new Casilla[1];
                casillas[0] = new Casilla(x, y, EstadoCasillaBarco.intacto);
            }
            else
            {
                if (longitud == 2)
                {
                    Casilla[] casillas = new Casilla[2];
                    if (_posicion == posicion.horizontal)
                    {
                        casillas[0] = new Casilla(x, y, EstadoCasillaBarco.intacto);
                        casillas[1] = new Casilla(x + 1, y, EstadoCasillaBarco.intacto);
                    }
                    else
                    {
                        casillas[0] = new Casilla(x, y, EstadoCasillaBarco.intacto);
                        casillas[1] = new Casilla(x, y + 1, EstadoCasillaBarco.intacto);
                    }
                }

            }
        }
    }
}