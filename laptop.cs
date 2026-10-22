class Laptop : Computer
{
    public double Weight;

    public void WeightCheck()
    {
        if (Weight <= 2)
        {
            Console.WriteLine("1,5 kilo ");
        }
        else
        {
            Console.WriteLine("4 kilo");
        }
    }
}