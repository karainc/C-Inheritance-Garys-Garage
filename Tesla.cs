namespace Garage
{
    public class Tesla : Vehicle  // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        //Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives past. Vrooooom!"); //To have each vehicle make its own sound, you need to do two things. 2)Override the method in the child class.
        }
    }
}