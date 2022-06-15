using CompositeDesignPattern;

var menu = new RightMenu("Menu");
var profile = new RightMenu("Profile");
var correspondence = new RightMenu("Correspondence");
var request = new RightMenu("Request");

var setting = new RightMenuItem("Setting", "/setting.html");
var inbox = new RightMenuItem("Inbox Letters", "/inbox.html");
var outbox = new RightMenuItem("Outbox Letters", "/outbox.html");
var loan = new RightMenuItem("Loan Requests", "/loan.html");
var temp = new RightMenuItem("Inbox Temp", "/inboxtemp.html");

profile.Add(setting);
correspondence.Add(inbox);
correspondence.Add(outbox);
request.Add(loan);
inbox.Add(temp);

Console.WriteLine($"\r\n************* profile\r\n{profile}\r\n");
Console.WriteLine($"\r\n************* correspondence\r\n{correspondence}\r\n");
Console.WriteLine($"\r\n************* request\r\n{request}\r\n");

Console.WriteLine($"\r\n************* setting\r\n{setting}\r\n");
Console.WriteLine($"\r\n************* inbox\r\n{inbox}\r\n");
Console.WriteLine($"\r\n************* outbox\r\n{outbox}\r\n");
Console.WriteLine($"\r\n************* loan\r\n{loan}\r\n");

Console.WriteLine($"\r\n************* temp\r\n{temp}\r\n");

menu.Add(profile);
menu.Add(correspondence);
menu.Add(request);

Console.WriteLine($"\r\n************* menu\r\n{menu}\r\n");