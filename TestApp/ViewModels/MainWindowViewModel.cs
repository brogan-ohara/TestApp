using System;
using System.Collections.Generic;
using System.Text;
using TestApp.Models;

namespace TestApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public List<Person> People1
        {
            get;
        }

        public List<Person> People2
        {
            get;
        }

        public MainWindowViewModel()
        {
            People1 = new List<Person>();
            People2 = new List<Person>();

            for (var i = 0; i < 150; i++)
            {
                People1.Add(new Person
                {
                    FirstName = "John",
                    LastName = "Smith",
                    Age = 30,
                    EmployeeID = 56635,
                    CubeAddress = "D19",
                    HomeAddress = "743 Harvard Ave",
                    JobTitle = "Senior Hardware Engineer",
                    Major = "Electrical Enginering",
                    Company = "Texas Instruments",
                    University = "Stanford",
                    YearsActive = 5
                });

                People2.Add(new Person
                {
                    FirstName = "Wendy",
                    LastName = "Winters",
                    Age = 24,
                    EmployeeID = 3756,
                    CubeAddress = "C13",
                    HomeAddress = "45 Pensacla Ct",
                    JobTitle = "Jr. Software Engineer",
                    Major = "Software Enginering",
                    Company = "Texas Instruments",
                    University = "Cal",
                    YearsActive = 1
                });
            }
        }
    }
}
