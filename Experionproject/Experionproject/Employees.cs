using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experionproject
{
    internal class Employees
    {
        public string Name { get; set; }

        public string Department { get; set; }

        private int _salary;

        public int Salary
        {
            get { return _salary; }
        }

        private string _designation;

        public string Designation
        {
            get { return _designation; }
            set {
                if (value== "Trainee") 
                {
                    _salary = 5000;
                }
                if (value == "Manager") 
                {
                    _salary = 200000;
                }
                if(value == "Senior employee")
                {
                    _salary = 130000;
                }
                _designation = value;   
            }
        }


    }
}
