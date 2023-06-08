namespace Garage
{
    public class Vehicle
    {
        public string? MainColor { get; set; }
        public int? MaximumOccupancy { get; set; }


        public virtual void Drive()
        {
            Console.WriteLine("Vroooom!");
        }

        
        //Create a Turn(string direction) mathod. Define a basic implementation.
        public virtual void Turn(string direction)
        {
            Console.WriteLine("The vehicle turns left.");
        }

        //Create a Stop() method on Vehicle. Define a basic implementation.
        public virtual void Stop()
        {
            Console.WriteLine("The vehicle rolls gently to a stop.");
        }
    }
}