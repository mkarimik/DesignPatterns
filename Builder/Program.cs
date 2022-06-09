using BuilderDesignPattern;

var pepperoniBuilder = new PepperoniPizzaBuilder(700);
var bake = new Bake(pepperoniBuilder);
var pepperoni = bake.Build();
Console.WriteLine(pepperoni);
