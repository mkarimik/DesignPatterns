using AdapterDesignPattern.Tehran;

namespace AdapterDesignPattern.CenterOfTehran;

public class TehranAdapter : IMainEmployees
{
    List<Employee> _employeeList;

    public TehranAdapter(List<Employee> employeeList)
    {
        _employeeList = employeeList;
    }

    public List<MainEmployee> GetEmployees()
    {
        return _employeeList.Select(e => 
                                        new MainEmployee
                                        { 
                                            Name = e.Name, 
                                            Family = e.Family, 
                                            NationalCode = e.NationalCode, 
                                            PersonnelCode = e.PersonnelCode, 
                                            CityName = "Tehran" 
                                        })
                                        .ToList();
    }
}