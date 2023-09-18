﻿using System;

namespace FormComplejos_G2_2024_I
{
    internal class Complejo
    {
        private float real;
        private float imaginaria;

        public Complejo(float real, float imaginaria)
        {
            this.real = real;
            this.imaginaria = imaginaria;
        }

        public static Complejo operator +(Complejo c1, Complejo c2)
        {
            // Complejo c3 = new Complejo(c1.real+c2.real, c1.imaginaria + c2.imaginaria    );
            return new Complejo(c1.real + c2.real, c1.imaginaria + c2.imaginaria);
        }

        public static Complejo operator ~(Complejo c)
        {
            return new Complejo(c.real, -c.imaginaria);
        }

        public static Complejo operator *(Complejo c1, Complejo c2)
        {
            return new Complejo(c1.real * c2.real - c1.imaginaria * c2.imaginaria, c1.real * c2.imaginaria + c2.real * c1.imaginaria);
        }
            

        public override string ToString()
        {
            if( imaginaria >= 0 )
            
             return String.Format(" {0} + {1}i",real,imaginaria );
            else
                return String.Format(" {0}  {1}i", real, imaginaria);


        }

    }
}
