using System.Collections;

namespace AdapterDesignPattern.CenterOfTehran;

public class EsfehanAdapter : IMainEmployees
{
    ArrayList _employeeList;
    
    public EsfehanAdapter(ArrayList employeeList)
    {
        _employeeList = employeeList;
    }

    public List<MainEmployee> GetEmployees()
    {
        var result = new List<MainEmployee>();

        foreach (var employee in _employeeList)
        {
            result.Add(new MainEmployee{
                Name = ((List<string>)employee)[1],
                Family = ((List<string>)employee)[2],
                NationalCode = ((List<string>)employee)[3],
                PersonnelCode = ((List<string>)employee)[4],
                CityName = "Esfehan"
            });    
        }

        return result;
    }
}
