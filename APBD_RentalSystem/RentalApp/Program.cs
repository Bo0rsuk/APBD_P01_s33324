using DataModels;
using DataModels.Abstracts;
using DataProcessing;
using BusinessLogic;

IDataRepository repository = new DataRepository();
IBusinessLogic logic = new BusinessLogic.BusinessLogic(repository);


Console.WriteLine("=== Rental App Demo ===\n" +
    "this will showcase working aspects of the assignment\n" +
    "You will be occasionally asked to press some key in order to proceed");

int logNumber = 1;
Console.WriteLine($"\n{logNumber}. Empty data repository showcase:");

PrintCollection(logic.GetAllPeople());
PrintCollection(logic.GetAllEquipment());
PrintCollection(logic.GetAllRentals());

Pause();
logNumber++;

Console.WriteLine($"\n{logNumber}. Adding people...");

logic.AddStudent("Josh", "Kerr", 3.5m, "CS");
logic.AddStudent("Anna", "Hall", 4.0m, "Chemistry");
logic.AddEmployee("Jakob", "Ingebrigsten", "Boss", 10000m);
logic.AddEmployee("Grant", "Fisher", "Manager", 6000m);

PrintCollection(logic.GetAllPeople());

Pause();
logNumber++;

Console.WriteLine($"\n{logNumber}. Adding equipment...");

logic.AddLaptop(5.5m, "ThinkPad E16", 16, 1024);
logic.AddLaptop(3.2m, "Makbook Pro", 31, 4096);
logic.AddCamera(1m, "Cannon Mini", 128, 16);
logic.AddCamera(0.8m, "GoPro Turbo", 24, 64);
logic.AddHeadset(0.5m, "Logitech Pro", false, true);
logic.AddHeadset(0.7m, "Corsair Pro W", true, true);

PrintCollection(logic.GetAllEquipment());

Pause();
logNumber++;

Console.WriteLine($"\n{logNumber}. Fetching people and equipment by Id...");

int toFetchId = 1;

var person = logic.get







// Helper methods
static void PrintCollection<T>(IEnumerable<T> items)
{
    if (!items.Any())
    {
        Console.WriteLine("(empty)");
        return;
    }

    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}
static void Pause()
{
    Console.WriteLine("\nPress any key to continue...\n");
    Console.ReadKey();
}