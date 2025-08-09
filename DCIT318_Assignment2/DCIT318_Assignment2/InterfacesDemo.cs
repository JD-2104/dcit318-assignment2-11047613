using System;

public interface IMovable
{
    void Move();
}

public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

public class ProgramTask3
{
    public static void Main(string[] args)
    {
        IMovable myCar = new Car();
        IMovable myBike = new Bicycle();

        myCar.Move();
        myBike.Move();
    }
}
