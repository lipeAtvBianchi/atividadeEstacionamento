namespace estacionamento.Models
{
    public class Parking
    {
        public Parking() { }

        public Parking(decimal initialPrice, decimal valuePerHour)
        {
            InitialPrice = initialPrice;
            ValuePerHour = valuePerHour;
        }

        private decimal InitialPrice { get; set; }
        private decimal ValuePerHour { get; set; }
        private List<string> Vehicles = new List<string>();


        public void InsertVehicleList(string vehicle, int hour)
        {

            if (AlreadyExists(vehicle))
            {
                Console.WriteLine("The vehicle is already in the parking");
            }
            else
            {
                Vehicles.Add(vehicle.ToUpper() + $", hours in: {hour}, total payment: {(InitialPrice + (hour * ValuePerHour)).ToString("c")}");
            }
        }

        public void RemoveVehicleFromList(string vehicle)
        {
            if (!AlreadyExists(vehicle))
            {
                Console.WriteLine($"There is no {vehicle} in the parking");
            }
            else
            {
                Vehicles.RemoveAll(v => v.Contains(vehicle));
            }
        }

        private bool AlreadyExists(string vehicle)
        {
            string vehiclePrefix = vehicle.Substring(0, Math.Min(8, vehicle.Length));
            if (Vehicles.Any(v => v.StartsWith(vehiclePrefix, StringComparison.OrdinalIgnoreCase)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShowVehiclesList()
        {
            if (Vehicles.Any())
            {
                Console.WriteLine("\nVehicles in the park: \n");
                foreach (var vehicle in Vehicles)
                {
                    Console.WriteLine(vehicle);
                }
            }
            else
            {
                Console.WriteLine("The parking is empty");
            }

        }
    }
}