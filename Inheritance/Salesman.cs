public class Salesman : IEmployees

{
    private string _region;

    //property

    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public long? Age { get; set; }
    public double? Salary { get; set; }



    //property
    public int? SalesmanID { get; set; }
    public string? SalesmanName { get; set; }
    public int? sales { get; set; }

    public int GetEmployeeAge()
    {
        return (int)(Age + Salary);

    }
    /*  double? IEmployees.Salary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
      long? IEmployees.Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }*/


    public Salesman(int EmployeeId, string Name, long Age, double Salary, int SalesmanID, string SalesmanName, int sales, string region)
    {
        this.EmployeeId = EmployeeId;
        this.Name = Name;
        this.Age = Age;
        this.Salary = Salary;
        this.SalesmanID = SalesmanID;
        this.SalesmanName = SalesmanName;
        this.sales = sales;
        this._region = region;
    }

    //method

    public long GetTotalSalesOfTheMonth()
    {
        return 1000;
    }
}