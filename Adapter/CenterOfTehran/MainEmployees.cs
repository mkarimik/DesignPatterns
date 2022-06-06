namespace AdapterDesignPattern.CenterOfTehran;

public class MainEmployees : IMainEmployees
{
    List<MainEmployee> _employeeList;

    public MainEmployees(List<MainEmployee> employeeList)
    {
        _employeeList = employeeList;
    }

    public List<MainEmployee> GetEmployees()
    {
        return _employeeList;
    }

    public override string ToString()
    {
        string result = "";

        foreach (var employee in _employeeList)
        {
            result += $"{{Name={employee.Name}, Family={employee.Family}, NationalCode={employee.NationalCode}, PersonnelCode={employee.PersonnelCode}, CityName={employee.CityName}}}\r\n";
        }

        return result;
    }
}