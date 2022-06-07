using AdapterDesignPattern.CenterOfTehran;

// Employees class for Tehran city employees 
var tehran = new AdapterDesignPattern.Tehran.Employees();
// Employees class for Esfehan city employees 
var esfehan = new AdapterDesignPattern.Esfehan.Employees();
// Employees class for Shiraz city employees 
var shiraz = new AdapterDesignPattern.Shiraz.Employees();

Console.WriteLine("All personnel of Tehran : ");
Console.WriteLine(tehran);

Console.WriteLine("All personnel of Esfehan : ");
Console.WriteLine(esfehan);

Console.WriteLine("All personnel of Shiraz : ");
Console.WriteLine(shiraz);

// MainEmployees is a class for keep the final List<MainEmployee> 
var mainEmployees = new MainEmployees();

// tehranEmployees is a list of Employee class => List<AdapterDesignPattern.Tehran.Employee>
var tehranEmployees = tehran.GetEmployees();
// tehranAdapter is an adapter for change the List<AdapterDesignPattern.Tehran.Employee> to List<MainEmployee>
var tehranAdapter = new TehranAdapter(tehranEmployees);
// tehranAdaptered is a List<MainEmployee> of Tehran employees
var tehranAdaptered = tehranAdapter.GetEmployees();
// Concat data for final List<MainEmployee> 
mainEmployees.SetEmployees(tehranAdaptered);

// esfehanEmployees is a System.Collections.ArrayList of List<string> that is list of employee info   
var esfehanEmployees = esfehan.GetEmployees();
// esfehanAdapter is an adapter for change System.Collections.ArrayList of List<string> to List<MainEmployee>
var esfehanAdapter = new EsfehanAdapter(esfehanEmployees);
// esfehanAdaptered is a List<MainEmployee> of Esfehan employees
var esfehanAdaptered = esfehanAdapter.GetEmployees();
// Concat data for final List<MainEmployee> 
mainEmployees.SetEmployees(esfehanAdaptered);

// shirazEmployees is a string[][] that is array of employee array info
var shirazEmployees = shiraz.GetEmployees();
// shirazAdapter is an adapter for change string[][] to List<MainEmployee>
var shirazAdapter = new ShirazAdapter(shirazEmployees);
// shirazAdaptered is a List<MainEmployee> of Shiraz employees
var shirazAdaptered = shirazAdapter.GetEmployees();
// Concat data for final List<MainEmployee> 
mainEmployees.SetEmployees(shirazAdaptered);

// Print final List<MainEmployee>
Console.WriteLine("All personnels : ");
Console.WriteLine(mainEmployees);
