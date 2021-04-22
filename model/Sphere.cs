using System;
using System.Collections.Generic;
using System.Text;

namespace oop.model
{
    /// <summary>
    /// Gömb osztály
    /// </summary>
    class Sphere
    {
        /// <summary>
        /// A gömb sugara
        /// </summary>
        private double radius;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="radius">A gömb sugara</param>
        public Sphere(double radius)
        {
            if (radius < 0)
                throw new ExceptionSphereRadiusNegativOrZero("A kör suagra nem lehet negatív vagy nulla.");
            this.radius = radius;
        }

        /// <summary>
        /// Sugár, írható tulajdonság
        /// </summary>
        public double Radius
        {
            set
            {
                if (value <= 0)
                    throw new ExceptionSphereRadiusNegativOrZero("A kör sugara nem lehet negatív vagy nulla.");
                radius = value;
            }
        }

        /// <summary>
        /// A gömt felszíne 
        /// </summary>
        public double Surface
        {
            get { }
        }

        /// <summary>
        /// A kör térfogata
        /// </summary>
        public double Volume
        {
            get { }
        }
    }
}
