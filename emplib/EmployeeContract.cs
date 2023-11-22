using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emplib
{
    public interface EmployeeContract
    {
        void viewcontract();

        void sign();
        string FillTimsheets(List<string>  ptasks, DateTime timings );
    }
}
