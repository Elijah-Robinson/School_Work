using System;


public class manager : employee
{
    private string region;
    private string department;


    public manager(string firstName, string lastName, string id, string department, string region)
    : base(firstName, lastName, id, EmployeeType.Manager)
    {
        this.department = department;
        this.region = region;
    }

    public void setR(string region)
    {
        this.region = region;
    }

    public string getRegion()
    {
        return region;
    }

    public void setDepartment(string department)
    {
        this.department = department;
    }

    public string getDepartment()
    {
        return department;
    }
    //parameters in set
}
