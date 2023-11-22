using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static shapelib.ishape;

namespace shapelib
{
    public interface ishape
        {
        void draw();


        //void draw();

        void getdetails();
        //string FillTimsheets(List<string> ptasks, DateTime timings);
    }
    
}


