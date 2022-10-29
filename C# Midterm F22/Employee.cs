using System;

public enum EmployeeType { Sales, Manager, Production }

public class employee
{
    private string id;
    private string firstName;
    private string lastName;
    private EmployeeType empType;


    public employee(string firstName, string lastName, string id, EmployeeType empType)
    {

        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
        this.empType = empType;
    }
    public void getEmpInfo()
    {
        Console.WriteLine($"Employee Name: {firstName} {lastName}");
        Console.WriteLine($"Employee ID: {id}");
        Console.WriteLine($"Employee Type: {empType}");
    }

    public void setFirst(string firstName)
    {
        this.firstName = firstName;
    }

    public string getFirst()
    {
        return firstName;
    }

    public void setLast(string lastName)
    {
        this.lastName = lastName;
    }

    public string getLast()
    {
        return lastName;
    }

    public string getID()
    {
        return id;
    }

    public void setEmp(EmployeeType empType)
    {
        this.empType = empType;
    }

    public EmployeeType GetEmpType()
    {
        return empType;
    }
}