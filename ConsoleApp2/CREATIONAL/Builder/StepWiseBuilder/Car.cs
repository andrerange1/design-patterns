namespace DesignPatterns.CREATIONAL
{
    public class Car
    {
        public CarType Type;
        public int WheelSize;

        public override string ToString()
        {
            return $"Car type: {Type} | WheelsSize: {WheelSize} ";
        }
    }
}

