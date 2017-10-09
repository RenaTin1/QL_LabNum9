using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber9
{
    class Circle
    {
        //Variable
        private double radius;

         //Property
        public double Radius
        {
            set {radius = value;}
            get { return radius; }
        }
       
        //Methods
        public double GetArea()
        {
            double pi = Math.PI;
            double area = pi * radius * radius;
            return area;
        }

        public double GetCircumference()
        {     
            double pi = Math.PI;
            double circumference = 2 * pi * radius;
            return circumference;
        }
    }
}
