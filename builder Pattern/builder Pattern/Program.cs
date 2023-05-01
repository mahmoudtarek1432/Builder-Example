// See https://aka.ms/new-console-template for more information
using builder_Pattern.Real;
using builder_Pattern.Structure;

testReal();


Console.ReadLine();

void testStructure()
{
    Director director = new Director();

    Builder builder1 = new ConcreteBuilder1();
    director.construct(builder1);
    Product p1 = builder1.Result();
    p1.show();

    Builder builder2 = new ConcreteBuilder2();
    director.construct(builder2);
    Product p2 = builder2.Result();
    p2.show();

}

void testReal()
{
    chain<MotorcycleBuilder>();
    chain<CarBuilder>();
}

void chain<T>() where T: VehicleBuilder, new()
{
    Factory factory = new Factory();

    VehicleBuilder Vb = new T();
    factory.Construct(Vb);
    Vb.vehicle.show();
}