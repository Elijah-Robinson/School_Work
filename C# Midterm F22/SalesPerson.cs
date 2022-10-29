using System;

enum SalesLevel
{
    Platinum,
    Diamond,
    Gold,
    Silver,
    Bronze
}

class salesPerson : employee
{
    private float sales;
    private string department;



    public salesPerson(string firstName, string lastName, string id, string department, float sales)
    : base(firstName, lastName, id, EmployeeType.Sales)
    {
        this.department = department;
        this.sales = sales;
    }

    public void updateSales(float salesAmmount)
    {
        sales = sales + salesAmmount;
    }

    public string getDepartment()
    {
        return department;
    }

    public void setDepartment(string department)
    {
        this.department = department;
    }

    public float totSales()
    {
        return sales;
    }

    public void setSale(float sales)
    {
        this.sales = sales;
    }

    public SalesLevel newLevel()
    {
        if (sales <= 9999)
        {
            return SalesLevel.Bronze;
        }
        else if (sales >= 10000 && sales < 20000)
        {
            return SalesLevel.Silver;
        }
        else if (sales >= 20000 && sales < 30000)
        {
            return SalesLevel.Gold;
        }
        else if (sales >= 30000 && sales < 40000)
        {
            return SalesLevel.Diamond;
        }
        else
        {
            return SalesLevel.Platinum;
        }

    }















}