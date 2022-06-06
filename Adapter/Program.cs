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

var tehranAdapter = new TehranAdapter(tehran.GetEmployees());
var all = tehranAdapter.GetEmployees();

var esfehanAdapter = new EsfehanAdapter(esfehan.GetEmployees());
all.AddRange(esfehanAdapter.GetEmployees());

var shirazAdapter = new ShirazAdapter(shiraz.GetEmployees());
all.AddRange(shirazAdapter.GetEmployees());

var mainEmployees = new MainEmployees(all);
Console.WriteLine("All personnels : ");
Console.WriteLine(mainEmployees);
