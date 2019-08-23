using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;

namespace TestApp.Models
{
    public class Person : ReactiveObject
    {
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public string Company
        {
            get;
            set;
        }
        public int YearsActive
        {
            get;
            set;
        }

        public int EmployeeID
        {
            get;
            set;
        }

        public string HomeAddress
        {
            get;
            set;
        }

        public string CubeAddress
        {
            get;
            set;
        }

        public string JobTitle
        {
            get;
            set;
        }

        public string University
        {
            get;
            set;
        }

        public string Major
        {
            get;
            set;
        }
    }
}
