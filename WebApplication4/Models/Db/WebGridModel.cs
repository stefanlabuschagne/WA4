using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace WebgridOrGridview.Models
{
    public class Employee
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
        public double Salary
        {
            get;
            set;
        }
        public static List<Employee> GetList()
        {
            List<Employee> Employees = new List<Employee> {
                    new Employee {
                        FirstName = "Satyaprakash1", LastName = "Samantaray1", Salary = 45000
                    },
                    new Employee {
                        FirstName = "Satyaprakash2", LastName = "Samantaray2", Salary = 25000
                    },
                    new Employee {
                        FirstName = "Satyaprakash3", LastName = "Samantaray3", Salary = 25000
                    },
                    new Employee {
                        FirstName = "Satyaprakash4", LastName = "Samantaray4", Salary = 35000
                    },
                    new Employee {
                        FirstName = "Satyaprakash5", LastName = "Samantaray5", Salary = 65000
                    },
                    new Employee {
                        FirstName = "Satyaprakash6", LastName = "Samantaray6", Salary = 75000
                    },
                    new Employee {
                        FirstName = "Satyaprakash7", LastName = "Samantaray7", Salary = 85000
                    },
                    new Employee {
                        FirstName = "Satyaprakash8", LastName = "Samantaray8", Salary = 95000
                    },
                };
            return Employees;
        }
    }
}