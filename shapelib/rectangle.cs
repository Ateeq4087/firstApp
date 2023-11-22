using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapelib
{
    public class rectangle :  ishape
    {
        public int length { get; set; }
        public int breadth { get; set; } 

        public string draw()
        {
            return $"{this.length}this is draw";
        }
        public string getdetails()
        {
            float area1 = (float)length * breadth;
            float peri = (float)2 * (length + breadth);
            return $"{this.length} is the length of rectangle\n{this.breadth} is the breadth of rectangle\n{area1}  is the Ara of rectangle\n{peri}  is the Perimeter of Rectangle";
        }

        void ishape.draw()
        {
            throw new NotImplementedException();
        }

        void ishape.getdetails()
        {
            throw new NotImplementedException();
        }

        public static implicit operator Rectangle(rectangle v)
        {
            throw new NotImplementedException();
        }
    }
}
