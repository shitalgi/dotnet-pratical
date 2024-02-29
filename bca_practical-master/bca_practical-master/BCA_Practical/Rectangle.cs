using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_Practical
{
    public class Rectangle : Shape
    {
        public int length;
        public int width;
        public Rectangle()
        { 
        
        }
        public Rectangle(int _lenght, int _width)
        {
            length = _lenght;
            width = _width;
        }

        public static Rectangle operator +(Rectangle r1, Rectangle r2)
        {
            Rectangle r = new Rectangle();
            r.length = r1.length + r2.length;
            r.width = r1.width + r2.width;
            return r;
        }
    }

}
