using System;
using System.Collections.Generic;
using System.Text;

namespace CircleProject.model
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
        /// <param name="radius">A kör sugara</param>
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
        /// A kör kerülete
        /// </summary>
        public double District
        {
            get
            {
                double district = 2 * radius * Math.PI;
                return district;
            }
        }

        /// <summary>
        /// A kör területe
        /// </summary>
        public double Area
        {
            get
            {
                double area = Math.Pow(radius, 2) * Math.PI;
                return area;
            }
        }

        /// <summary>
        /// Osztály karakterláncként
        /// </summary>
        /// <returns>Karakterlánc területtel, kerülettel</returns>
        public override string ToString()
        {
            double roundedDistrict = Math.Round(District, 2);
            double roundedArea = Math.Round(Area, 2);
            string output = radius + " sugarú kör területe " + roundedArea + ", kerülete " + roundedDistrict;
            return output;
        }
    }
}
