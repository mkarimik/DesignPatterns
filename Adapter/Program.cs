using AdapterDesignPattern.CenterOfTehran;

var tehran = new AdapterDesignPattern.Tehran.Employees();
var esfehan = new AdapterDesignPattern.Esfehan.Employees();
var shiraz = new AdapterDesignPattern.Shiraz.Employees();

Console.WriteLine("All personnel of Tehran : ");
Console.WriteLine(tehran);

Console.WriteLine("All personnel of Esfehan : ");
Console.WriteLine(esfehan);

Console.WriteLine("All personnel of Shiraz : ");
Console.WriteLine(shiraz);

var mainEmployees = new MainEmployees();

var tehranAdapter = new TehranAdapter(tehran.GetEmployees());
var tehranAdaptered = tehranAdapter.GetEmployees();
mainEmployees.SetEmployees(tehranAdaptered);

var esfehanAdapter = new EsfehanAdapter(esfehan.GetEmployees());
var esfehanAdaptered = esfehanAdapter.GetEmployees();
mainEmployees.SetEmployees(esfehanAdaptered);

var shirazAdapter = new ShirazAdapter(shiraz.GetEmployees());
var shirazAdaptered = shirazAdapter.GetEmployees();
mainEmployees.SetEmployees(shirazAdaptered);

Console.WriteLine("All personnels : ");
Console.WriteLine(mainEmployees);
