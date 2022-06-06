using System.Collections;

namespace AdapterDesignPattern.Esfehan;

public class Employees : IEmployees
{
     ArrayList _employeeList;

    public Employees()
    {
        _employeeList = new ArrayList
        {
            new List<string>{ "1", "Mahmood", "Kavyani", "4444444444", "4444" },
            new List<string>{ "2", "Yasin", "Mansoori", "5555555555", "5555" },
        };
    }

    public ArrayList GetEmployees()
    {
        return _employeeList;
    }

    public override string ToString()
    {
        string result = "";

        foreach (var employee in _employeeList)
        {
            result += $"{{Id={((List<string>)employee)[0]}, Name={((List<string>)employee)[1]}, Family={((List<string>)employee)[2]}, NationalCode={((List<string>)employee)[3]}, PersonnelCode={((List<string>)employee)[4]}}}\r\n";
        }

        return result;
    }
}