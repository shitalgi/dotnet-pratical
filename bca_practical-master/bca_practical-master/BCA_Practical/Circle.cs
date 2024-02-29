using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_Practical
{
    public class Circle
    {
        public int radius;
        public Circle()
        {
            radius = 1;
        }
        public Circle(int _radius)
        {
            this.radius = _radius;
        }
        public static Circle operator +(Circle c1, Circle c2)
        {
            Circle bigCircle = new Circle();
            bigCircle.radius = c1.radius + c2.radius;
            return bigCircle;
        }

        public static Circle operator *(Circle c1, Circle c2)
        {
            Circle bigCircle = new Circle();
            bigCircle.radius = c1.radius * c2.radius;
            return bigCircle;
        }

        public static Circle operator -(Circle c1, Circle c2)
        {
            Circle smallCircle = new Circle();
            smallCircle.radius = c1.radius - c2.radius;
            return smallCircle;
        }


        public string GetArea()
        {
            double ar = 3.1416 * this.radius * this.radius;
            return ar.ToString();
        }

    }
}
