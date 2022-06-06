namespace AdapterDesignPattern.Tehran;

public class Employees : IEmployees
{
    List<Employee> _employeeList;

    public Employees()
    {
        _employeeList = new List<Employee>
        {
            new Employee{ Id = 1, Name = "Mohmmad", Family = "Karimi", NationalCode = "1111111111", PersonnelCode = "1111" },
            new Employee{ Id = 2, Name = "Alireza", Family = "Akbari", NationalCode = "2222222222", PersonnelCode = "2222" },
            new Employee{ Id = 2, Name = "Mohammad Reza", Family = "Kari", NationalCode = "3333333333", PersonnelCode = "3333" },
        };
    }

    public List<Employee> GetEmployees()
    {
        return _employeeList;
    }

    public override string ToString()
    {
        string result = "";

        foreach (var employee in _employeeList)
        {
            result += $"{{Id={employee.Id}, Name={employee.Name}, Family={employee.Family}, NationalCode={employee.NationalCode}, PersonnelCode={employee.PersonnelCode}}}\r\n";
        }

        return result;
    }
}