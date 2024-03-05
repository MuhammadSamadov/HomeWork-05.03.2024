namespace task1;

public class Car : IVehicle
{
    int _gas;
    public Car(int gasoline)
    {
        _gas=gasoline;
    }
    public void Drive()
    {
        if(_gas>0)
        {
            System.Console.WriteLine("Driving");
        }
    }

    public bool Refuel(int gas)
    {
        _gas+=gas;
        return true;
    }
}
