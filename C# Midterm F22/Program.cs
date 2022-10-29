using System;
//changed the varible names becasue its just easier to read and analyze for me. Sorry haha


namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create instances of Employee, SalesPerson, and Manager
            employee emp1 = new employee("Truman", "Tiger", "12345", EmployeeType.Sales);
            salesPerson sp1 = new salesPerson("Mickey", "Mouse", "23456", "Sporting Goods", 7500);
            manager man1 = new manager("Elmer", "Fudd", "56789", "Electronics", "Midwest");

            Console.WriteLine("\n-------Employee 1-------------");
            emp1.getEmpInfo();

            Console.WriteLine("\n-------Sales Person 1-------------");
            sp1.getEmpInfo();
            Console.WriteLine($"Sales Level: {sp1.newLevel()} | Sales: ${sp1.totSales()}");
            sp1.updateSales(5250.70f);
            Console.WriteLine($"Updated Sales Level: {sp1.newLevel()} | Updated Sales: ${sp1.totSales()}");

            Console.WriteLine("\n-------Manager 1-------------");
            man1.getEmpInfo();
            Console.WriteLine($"Dept: {man1.getDepartment()} | Region: {man1.getRegion()}");
            man1.setFirst("Wiley");
            man1.setLast("Coyote");
            man1.setR("Southeast");
            man1.setDepartment("Automotive");
            Console.WriteLine($"\nNew Name: {man1.getFirst()} {man1.getLast()}");
            Console.WriteLine($"New Dept: {man1.getDepartment()} | New Region: {man1.getRegion()}");

        }

    }

}













//notes 
// this. has to be first or it doesnt work? 
//public :base cant accsess if not pub??
//Employee(string id, string firstName, string lastName, EmployeeType empType)
