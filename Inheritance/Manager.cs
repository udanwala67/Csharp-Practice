public class Manager : IEmployees
{
    private int? _employeeId;
    private string _departmentName;

    public int EmployeeId { get; set; }


    public string Name { get; set;}

    public long? Age { get; set; }

    public double? Salary { get; set; }



    public int ManagerId { get; set; }
    public string? FullName { get; set; }
    public int? SalesOfYear { get; set; }

    public int GetEmployeeAge()
    {
        return (int)(Age + Salary);

    }

    public Manager(int EmployeeId, string Name, long Age, double Salary, int ManagerId, string FullName, int SalesOfYear, string departmentName)
    {
        this.EmployeeId = EmployeeId;
        this.Name = Name;
        this.Age = Age;
        this.Salary = Salary;
        this.ManagerId = ManagerId;
        this.FullName = FullName;
        this.SalesOfYear = SalesOfYear;
        this._departmentName = departmentName;
    }

    // method implementation  of the interface methods. 
    public long GetTotalSalesOfTheYear()
    {
        return 12000;
    }
}
