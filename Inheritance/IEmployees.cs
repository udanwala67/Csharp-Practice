// interface (name is inheritance but remember you  are doing interface abstract method
public interface IEmployees
{
   /* private int _employeeId;
    private string? _Name;
    private long? _age;
    private double? _salary;*/

    // the feilds defined by interfaces are by default public so no need to explicitli define it
    // abstract mehods

     int EmployeeId { get; set; }
     string? Name { get; set; }
     long? Age { get; set; }
     double? Salary { get; set; }

    public int GetEmployeeAge()
    {
        return (int)(Age + Salary);

    }
}