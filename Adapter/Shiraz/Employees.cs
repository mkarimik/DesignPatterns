using System.Collections;

namespace AdapterDesignPattern.Shiraz;

public class Employees : IEmployees
{
     string[][] _employeeList;

    public Employees()
    {
        _employeeList = new string[][]
        {
            new string[] { "1", "Ahmad", "Malek", "6666666666", "6666" },
        };
    }

    public string[][] GetEmployees()
    {
        return _employeeList;
    }

    public override string ToString()
    {
        string result = "";

        foreach (var employee in _employeeList)
        {
            result += $"{{Id={employee[0]}, Name={employee[1]}, Family={employee[2]}, NationalCode={employee[3]}, PersonnelCode={employee[4]}}}\r\n";
        }

        return result;
    }
}