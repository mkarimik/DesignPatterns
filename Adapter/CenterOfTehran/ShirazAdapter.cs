using System.Collections;

namespace AdapterDesignPattern.CenterOfTehran;

public class ShirazAdapter : IMainEmployees
{
    string[][] _employeeList;

    public ShirazAdapter(string[][] employeeList)
    {
        _employeeList = employeeList;
    }

    public List<MainEmployee> GetEmployees()
    {
        var result = new List<MainEmployee>();

        for (int i = 0; i < _employeeList.Length; i++)
        {
            result.Add(new MainEmployee
            {
                Name = _employeeList[i][1],
                Family = _employeeList[i][2],
                NationalCode = _employeeList[i][3],
                PersonnelCode = _employeeList[i][4],
                CityName = "Shiraz"
            });
        }

        return result;
    }
}
