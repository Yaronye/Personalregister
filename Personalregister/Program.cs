namespace Personalregister
{
    /*utveckla personalregister med följande krav:
    1. Registret ska kunna ta emot och lagra anställda med namn och lön (inmatning i konsolen, inget krav på persistent lagring)
    2. Programmet ska kunna skriva ut registret i en konsol
    
     Initiella tankar:
    skapa txt fil där all info läses från/ skrivs till
    
     U1: Vilka klasser bör ingå i programmet?
    S1: en klass för anställda
    
     U2: Vilka attribut och metoder bör ingå i dessa klasser?
    S2: attribut: namn och lön
        metoder: print_register
    
     U3: Skriv programmet.
    S3:*/

    public class Employee(string name, int pay)
    {
        int pay = pay;
        string name = name;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the employees name");
            string varName = Console.ReadLine();
            Console.WriteLine("Enter the employees monthly pay");
            string strPay = Console.ReadLine();
            int varPay = 0;

            try
            {
                varPay = Int32.Parse(strPay);

            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{strPay}'");
            }

            Console.WriteLine("Add a new employee to the register with the name: {0} and monthly pay of: {1} ? Y/N", varName, strPay);
            string text = Console.ReadLine();

            if(text == "Y" || text == "y")
            {
                Employee myObj = new Employee(varName, varPay);
                Console.WriteLine("Employee {0} has been added to the register.", myObj.name);
                string docPath = 
            }
            else if(text == "N" || text == "n")
            {
                Console.WriteLine("Understood, no changes were made to the register.");
            }
            else
            {
                Console.WriteLine("Please answer using 'Y' or 'N'. ");
            }

        }
        
    }
}
