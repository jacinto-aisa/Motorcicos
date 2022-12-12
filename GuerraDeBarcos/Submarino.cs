using System;
using System.Collections.Generic;
using System.Text;

namespace GuerraDeBarcos
{
    public enum posicion { vertical, horizontal}
    public class Submarino : Barco
    {
        public Submarino (int x,int y):base(x,y,posicion.horizontal,1)
        {
           
        }
    }
   



    
}