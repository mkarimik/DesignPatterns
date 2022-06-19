using MediatorDesignPattern;


var mediatorManager = new MediatorManager();
var customer = new Customer(mediatorManager);
var waiter = new Waiter(mediatorManager);
var chef = new Chef(mediatorManager);

customer.SendMessage("I have an order, want a pizza.");
waiter.SendMessage("The customer is wanted a pizza. Please make it.");
chef.SendMessage("I made the pizza.");