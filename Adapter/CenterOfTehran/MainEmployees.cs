namespace AdapterDesignPattern.CenterOfTehran;

public class MainEmployees : IMainEmployees
{
    List<MainEmployee> _employeeList;

    public MainEmployees()
    {
        _employeeList = new List<MainEmployee>();
    }

    public List<MainEmployee> SetEmployees(List<MainEmployee> employeeList)
    {
        _employeeList.AddRange(employeeList);
        return _employeeList;
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