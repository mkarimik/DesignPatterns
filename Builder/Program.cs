using BuilderDesignPattern;

var pepperoniBuilder = new PepperoniPizzaBuilder(700);
var pepperoniBaker = new Bake(pepperoniBuilder);
var pepperoni = pepperoniBaker.Build();
Console.WriteLine(pepperoni);

var chickenBuilder = new ChickenPizzaBuilder(950);
var chickenBaker = new Bake(chickenBuilder);
var chicken = chickenBaker.Build();
Console.WriteLine(chicken);
