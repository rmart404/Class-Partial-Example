using System;
using System.Text;

namespace  EmployeeApp
{
    partial class Employee
    {
            //properties

        private string _empName;
        public string Name
        {
            get => _empName;
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Exceeds 15 Characters!");
                }
                else
                {
                    _empName = value;
                }
            }
        }


        public int Id { get; set; }

        public float Pay { get; set; }

        public int Age { get; set; }
        public EmployeePayTypeEnum PayType { get; set; }

        //public string SocialSecurityNumber => _empSSN;
        
        private string _empSSN;
        public string SocialSecurityNumber
        {
            get => _empSSN;
            private set => _empSSN = value;
        }
    }
}
