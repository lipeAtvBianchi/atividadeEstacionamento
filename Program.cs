using estacionamento.Models;

decimal initialPrice = 0M; decimal pricePerHour = 0M;

Console.WriteLine("Choose the initial price: "); initialPrice = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Choose the price per hour: "); pricePerHour = Convert.ToDecimal(Console.ReadLine());

Parking park = new Parking(initialPrice, pricePerHour);

int choose = 0;
string vehicle;
int hour;
while (choose != 4)
{
    Console.WriteLine("1 - Add car to the parking lot\n2 - Remove car from parking lot\n3 - List cars in the parking lot\n4 - Quit");
    choose = Convert.ToInt32(Console.ReadLine());
    switch (choose)
    {
        case 1:
            Console.WriteLine("Add the license plate");
            vehicle = Console.ReadLine();
            Console.WriteLine("Add the hours you will stay");
            hour = Convert.ToInt32(Console.ReadLine());
            if (vehicle != null && hour != 0)
            {
                park.InsertVehicleList(vehicle, hour);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("write a valid license plate or a time other than 0");
            }
            break;
        case 2:
            Console.WriteLine("Add the license plate");
            vehicle = Console.ReadLine();
            if (vehicle != null)
            {
                park.RemoveVehicleFromList(vehicle);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("write a valid license plate");
            }
            break;
        case 3:
            park.ShowVehiclesList();
            break;
        case 4:
            Console.WriteLine("Bye!");
            break;
        default:
            Console.WriteLine("Invalid Option!");
            break;
    }
    
}

