namespace Labb_4_Collection_and_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Anton Hansson SUT23 
            
            Employee Stella = new Employee() //Här skapar jag objekt för alla anställda, med olika egenskaper.
            {
                ID = 101,
                Name = "Stella",
                Gender = "Female",
                Salary = 25000
            };
            Employee Jessica = new Employee()
            {
                ID = 102,
                Name = "Jessica",
                Gender = "Female",
                Salary = 28000
            };
            Employee Peter = new Employee()
            {
                ID = 103,
                Name = "Peter",
                Gender = "Male",
                Salary = 33000
            };
            Employee Adam = new Employee()
            {
                ID = 104,
                Name = "Adam",
                Gender = "Male",
                Salary = 35000
            };
            Employee Anton = new Employee()
            {
                ID = 105,
                Name = "Anton",
                Gender = "Male",
                Salary = 42000
            };

            Stack<Employee> employeeStack = new Stack<Employee>(); //Stack

            employeeStack.Push(Stella);//Pushar alla objekt.
            employeeStack.Push(Jessica);
            employeeStack.Push(Peter);
            employeeStack.Push(Adam);
            employeeStack.Push(Anton);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Employees: ");
            Console.ResetColor();

            foreach ( Employee employee in employeeStack) //Skriver ut alla objekt samt antal items som finns kvar i min stack.
            {
                Console.WriteLine($"\nID : {employee.ID} , Name : {employee.Name} , Gender: {employee.Gender} , Salary {employee.Salary}. ");

                Console.WriteLine($"\nItems left in Stack = {employeeStack.Count}");
            }
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("\nEmployees with Pop Method: ");
            Console.ResetColor();

            while ( employeeStack.Count > 0 ) //Använder Pop metoden för att ta bort och skriva ut objekt.
            {
                Employee popEmployee = employeeStack.Pop();

                Console.WriteLine($"\nID : {popEmployee.ID} , Name : {popEmployee.Name} , Gender: {popEmployee.Gender} , Salary {popEmployee.Salary}. ");

                Console.WriteLine($"\nItems left in Stack = {employeeStack.Count}");
            }

            employeeStack.Push(Stella); //Lägger till alla objekt i min stack igen genom att pusha.
            employeeStack.Push(Jessica);
            employeeStack.Push(Peter);
            employeeStack.Push(Adam);
            employeeStack.Push(Anton);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nEmployees with Peek Method: ");
            Console.ResetColor();

            Employee peekEmployee = employeeStack.Peek(); //Använder Peek metoden för att skriva ut 2 objekt.

            Console.WriteLine($"\nID : {peekEmployee.ID} , Name : {peekEmployee.Name} , Gender:  {peekEmployee.Gender} , Salary {peekEmployee.Salary}. ");

            Console.WriteLine($"\nItems left in Stack = {employeeStack.Count}");

            Employee peekEmployee2 = employeeStack.Peek();
            Console.WriteLine($"\nID : {peekEmployee2.ID} , Name : {peekEmployee2.Name} , Gender:  {peekEmployee2.Gender} , Salary {peekEmployee2.Salary}. ");

            Console.WriteLine($"\nItems left in Stack = {employeeStack.Count}");
            

            
            int itemNumber = 3;  //Kollar om anställd nummer 3 finns i min stack eller inte.

            if (employeeStack.Count > itemNumber - 1) //-1 då index börjar på 0.
            {              
                Console.WriteLine($"\nEmployee number {itemNumber} is in Stack ");
            }
            else
            {
               Console.WriteLine($"\nEmployee number {itemNumber} is not in Stack");
            }

            List<Employee> employeeList = new List<Employee>(); //Skapar en List och lägger till objekten i listan genom Add metoden.

            employeeList.Add(Stella);
            employeeList.Add(Jessica);
            employeeList.Add(Peter);
            employeeList.Add(Adam);
            employeeList.Add(Anton);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nEmployees Contains Method");
            Console.ResetColor();

            if (employeeList.Contains(Jessica)) //Använder Contains metod för att kontrollera om den anställda/objektet finns i listan ller inte.
            {
                Console.WriteLine("\nEmployee 2 object exists in List");
            }
            else
            {
                Console.WriteLine("\nEmployee 2 object does not exist in List");
            }

            Employee findMaleEmployee = employeeList.Find(e => e.Gender == "Male"); //Använder Find metoden för att hitta det första male objekten i listan.

            Console.ForegroundColor= ConsoleColor.DarkBlue;
            Console.WriteLine("\nFirst Male Employee with Find Method");
            Console.ResetColor();

            Console.WriteLine($"\nID : {findMaleEmployee.ID} , Name : {findMaleEmployee.Name} , Gender:  {findMaleEmployee.Gender} , Salary {findMaleEmployee.Salary}. ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nAll Male Employees with Find All Method");
            Console.ResetColor();

            List <Employee> findMaleEmployees = employeeList.FindAll(e => e.Gender == "Male"); //Använder Find All metoden för hitta och skriva ut alla male objekt i listan.  

            foreach (Employee findEmployeeItem in findMaleEmployees)
            {
                Console.WriteLine($"\nID : {findEmployeeItem.ID} , Name : {findEmployeeItem.Name} , Gender:  {findEmployeeItem.Gender} , Salary {findEmployeeItem.Salary}. ");
            }

            Console.ReadKey();
          
        }
    }
}