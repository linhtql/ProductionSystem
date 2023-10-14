using ProductionSystem.Service;
using ProductionSystem.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSystem
{
    public class MyMenu
    {
        public static MyMenu myMenu;
        private MyMenu()
        {
        }

        public static MyMenu GetInstance()
        {
            return myMenu != null ? myMenu : new MyMenu();
        }

        public void GetMyMenu()
        {
            var employeeService = new EmployeeService();
            var listEmployees = employeeService.FindAll();
            ProductionService productionService = new ProductionService();
            var flag = true;
            while (flag)
            {
                Console.WriteLine("<-------List Employees------->");
                foreach (var item in listEmployees)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.WriteLine("Enter id employee do you want to query or Exit: ");

                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Enter choice feature valid!!!");
                }
                else if (input.Equals("exit"))
                {
                    flag = false;
                    Console.WriteLine("Thank use my system!!!");
                }
                else
                {
                    var employee = employeeService.FindById(input);
                    if (employee == null)
                    {
                        Console.WriteLine("Id not found!!");
                    }
                    else
                    {
                        Console.WriteLine("Enter date you need find (ex: 2023-09-07): ");
                        var date = Console.ReadLine();
                        if (CheckDate.IsValid(date))
                        {
                            var result = productionService.FindProductionByEmployeeId(input, date);

                            if (result.Count() == 0)
                            {
                                Console.WriteLine("No record!!");
                            }
                            else
                            {
                                foreach (var item in result)
                                {
                                    Console.WriteLine(item);
                                }
                                Console.WriteLine("---->QualifiedRate is: " + productionService.GetQualityRate(input, date) + "%");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Date is invalid!");
                        }

                    }
                }
            }
        }


    }
}
