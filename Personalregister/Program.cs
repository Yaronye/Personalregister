using System;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Personalregister
{
    /*utveckla personalregister med följande krav:
    1. Registret ska kunna ta emot och lagra anställda med namn och lön (inmatning i konsolen, inget krav på persistent lagring)
    2. Programmet ska kunna skriva ut registret i en konsol
    
     Initiella tankar:
    skapa txt fil där all info läses från/ skrivs till
    model view controller?
    
     U1: Vilka klasser bör ingå i programmet?
    S1: en klass för anställda
    
     U2: Vilka attribut och metoder bör ingå i dessa klasser?
    S2: attribut: namn och lön
        metoder: print_register
    
     U3: Skriv programmet.
    S3:*/

    public class Employee(string name, int pay)
    {
        int pay;
        string name;
        Employee myObj;

        static void Main(string[] args)
        {
            int varPay = 0;
            bool escape = false;
            var EmployeeList = new List<Employee>();
            /*do you want to: 
             * 1.add a new employee or 
             * 2. print? */


            while (!escape)
            {
                Console.WriteLine("What do you want to do?\n A. Add a new employee\n B. Print register\n C. Exit\n");
                string answer = Console.ReadLine();
                if(answer == "a" || answer == "A")
                {
                    string varName = newName();
                    string strPay = newPay();
                    varPay = convertPay(strPay);

                    Console.WriteLine("Add a new employee to the register with the name: {0} and monthly pay of: {1} ? Y/N", varName, strPay);
                    answer = Console.ReadLine();
                    if(answer == "Y" || answer == "y")
                    {
                        EmployeeList.Add(new Employee(varName, varPay));
                        Console.WriteLine("Employee has been added to the register.");

                    }
                    else if(answer == "N" || answer == "n")
                    {
                        Console.WriteLine("Understood, no changes were made to the register.");
                    }
                    else
                    {
                        Console.WriteLine("Please answer using 'Y' or 'N'. ");
                    }

                }
                else if(answer == "b" || answer == "B")
                {
                    foreach (var Employee in EmployeeList)
                    {
                        string name = Employee.name;
                        object pay = Employee.pay;
                        Console.WriteLine("{0} earns {1}kr", name, pay);
                    }
                }
                else if (answer == "c" || answer == "C")
                {
                    Console.WriteLine("Exiting program");
                    escape = true;
                }
                else
                {
                    Console.WriteLine("Please answer using 'A', 'B' or 'C'. ");
                }
            }   
        }
        public static string newName()
        {
            Console.WriteLine("Enter the employees name");
            return Console.ReadLine();
        }

        public static string newPay()
        {
            Console.WriteLine("Enter the employees monthly pay");
            return Console.ReadLine();
        }

        public static int convertPay(string strPay)
        {
            try
            {
                return Int32.Parse(strPay);

            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{strPay}', pay set to 0");
            }
            return 0;
        }
    }
}
