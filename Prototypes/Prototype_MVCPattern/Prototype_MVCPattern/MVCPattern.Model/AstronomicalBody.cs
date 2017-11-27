using System;

namespace Prototype_MVCPattern.MVCPattern.Model
{
    public class AstronomicalBody
    {
        /// <summary>
        /// Name of the Astronomical Body
        /// </summary>
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        /// <summary>
        /// Diameter of the Astronomical Body in earth Diameters
        /// </summary>
        private double _Diameter;
        public double Diameter
        {
            get { return _Diameter; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error! Astronomical Body Diameter must be greater than zero!");
                } else
                {
                    _Diameter = value;
                }
            }
        }

        /// <summary>
        /// Mass of the Astronomical Body in Earth Masses
        /// </summary>
        private double _Mass;
        public double Mass
        {
            get { return _Mass; }
            set
            {
                if (value <= 0 )
                {
                    Console.WriteLine("Error! Astronomical Body Mass must be greater than zero!");
                } else
                {
                    _Mass = value;
                }
            }
        }

        private string _ID;
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        /// <summary>
        /// Constructor of an Astronomical Body
        /// </summary>
        /// <param name="name">Name of the Body</param>
        /// <param name="diameter">Diameter in Earth Diameters</param>
        /// <param name="mass">Mass in Earth masses</param>
        public AstronomicalBody(string name, string id, double diameter, double mass)
        {
            Name = name;
            ID = id;
            Diameter = diameter;
            Mass = mass;
        }
    }
}
