namespace DesignPatterns.CREATIONAL.Builder 
{ 
    public static class SWBRoutineRester
    {
        public static void Run()
        {
            var car = CarBuilder.Create()
            .OfType(CarType.Crossover)
            .WithWheels(18)
            .Build();

            Console.WriteLine(car);

            var car2 = CarBuilder.Create().OfType(CarType.Sedan).WithWheels(16).Build();

            Console.WriteLine(car2);

        }
    }
}
