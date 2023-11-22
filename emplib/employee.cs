using emplib.empsysef;

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emplib
{
     public class employee :person, EmployeeContract
    {
        public event EventHandler join;
        public event EventHandler leave;
        public employee() : base()
        {
            this.viewcontract();
            this.sign();
            this.EmpID = new Random(1000).Next();
            //access utility function
            emputils.empcount++;
        }
        public employee (string pAadhaar) : this()
        {
            this.Aadhaar = pAadhaar;
        }
        
        private bool _contractsigned = false;
        private bool _hasreadcontract = true;
        
        public void joined()
        {
            this.join.Invoke(this, null);
        }
        public void resign()
        {
            this.leave.Invoke(this, null);
        }

        public void sign()
        {
            _contractsigned = true;
        }
        public void viewcontract()
        {
            _hasreadcontract = true;
        }

        public employee(string pAadhaar,string pphone):base(pAadhaar,pphone)
        {
            this.viewcontract();
            this.sign();
            this.EmpID = new Random(1000).Next();
            emputils.empcount++;
        }
        private int _empid;

      public int EmpID { get { return _empid; } private set { _empid = value; } }
      public string Designation {  get; set; }
      public double salary { get; set; }
      public DateTime DOJ { get; set; }
      public bool Isactive { get; set; }
      public void AttendTraining() { }
      public void FillTimesheets() { }

        public string AttendTraining (string ptraining)
        {
            return $"{this.Name} attended a Training {ptraining}";
        }

        public string FillTimsheets(List<string> ptasks, DateTime timings)
        {
            var csvTask = "";
            foreach (var Task in ptasks)
            {
                csvTask = $"{csvTask},{Task}";

            }
            return $"{this.Name} has worked on {csvTask} on {DateTime.Now.ToShortDateString()}";
        }
        public override string work()
        {
            return $"{this.Name} with {this.EmpID} works for 8hrs a day in KPMG";
        }

        public string work(string task)
        {
            return $"{this.Name} with {this.EmpID} has {task} assigned as {DateTime.Today}";
        }
        public void settaxinfo (string ptaxinfo)
        {
            this.taxdetails=ptaxinfo ;
        }
        public string gettaxinfo()
        {
            return $"{this.Name}: Your tax details are :{this.taxdetails}";
        }

        public static object Get()
        {
            throw new NotImplementedException();
        }

        static testempDB dbContext = new testempDB();


        //public static List<employee> Get() => dbContext.Employee1.Get();


    }
}
