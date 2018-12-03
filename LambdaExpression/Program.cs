using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List<Employee>();
            {
                EmployeeList.Add(new Employee
                {
                    ID = 1, FirstName = "Bob", LastName = "Smith"
                });

                EmployeeList.Add(new Employee
                {
                    ID = 2,
                    FirstName = "Joe",
                    LastName = "Jefferson"
                });

                EmployeeList.Add(new Employee
                {
                    ID = 3,
                    FirstName = "Joe",
                    LastName = "Lindstrom"
                });

                EmployeeList.Add(new Employee
                {
                    ID = 4,
                    FirstName = "Ross",
                    LastName = "Kelly"
                });

                EmployeeList.Add(new Employee
                {
                    ID = 5,
                    FirstName = "Joe",
                    LastName = "George"
                });

                EmployeeList.Add(new Employee
                {
                    ID = 6,
                    FirstName = "Steph",
                    LastName = "Johnson"
                });

                EmployeeList.Add(new Employee
                {
                    ID = 7,
                    FirstName = "Adam",
                    LastName = "Turner"
                });

                EmployeeList.Add(new Employee
                {
                    ID = 8,
                    FirstName = "Bob",
                    LastName = "Dylan"
                });

                EmployeeList.Add(new Employee
                {
                    ID = 9,
                    FirstName = "Larry",
                    LastName = "David"
                });

                EmployeeList.Add(new Employee
                {
                    ID = 10,
                    FirstName = "Jerry",
                    LastName = "Seinfeld"
                });

                List<Employee> EmployeeListJoe = new List<Employee>();
                //foreach loop
                foreach(Employee employee in EmployeeList)
                {
                    if (employee.FirstName == "Joe")
                    {
                        EmployeeListJoe.Add(new Employee
                        {
                            FirstName = employee.FirstName,
                            LastName = employee.LastName = employee.LastName,
                            ID = employee.ID
                        });
                    }
                }
                Console.WriteLine("A new list with only the employees with the first name Joe, has been created.");
                Console.ReadLine();


                //lambda expression

                List<Employee> newList = EmployeeList.Where(x => x.FirstName == "Joe").ToList();
                foreach (Employee employee in newList)
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.ID);
                    
                }
                Console.WriteLine("Above are the employees with the name Joe");
                Console.WriteLine("Now we will display which employees have a ID greaer than 5");
                Console.ReadLine();







                // lambda expression -- greater than 5
                List<Employee> listIdGreaterThan5 = EmployeeList.Where(x => x.ID > 5).ToList();

                
                foreach (Employee employee in listIdGreaterThan5)
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.ID);
                }



                Console.WriteLine("Press a key to continue");
                Console.ReadLine();
            }
        }
    }
}