using DataModels;
using DataModels.Abstracts;


namespace DataProcessing
{

    // optional TODO: make it singleton?
    public class DataRepository : IDataRepository
    {
        private static List<Person> _persons = new List<Person>(); //ik ik it's people...
        private static List<Equipment> _equipments = new List<Equipment>();
        private static List<RentalCard> _rentalCards = new List<RentalCard>();

        private static int _personId = 1;
        private static int _equipmentId = 1;
        private static int _rentalId = 1;

        // Person
        public void AddPerson(Person person)
        {
            _persons.Add(person);
        }
        public Person? GetPersonById(int id)
        {
            return _persons.FirstOrDefault(p => p.Id == id);
        }
        public List<Person> GetAllPeople()
        {
            return _persons;
        }

        // Equipment

        public void AddEquipment(Equipment equipment) 
        {
            _equipments.Add(equipment);
        }
        public Equipment? GetEquipmentById(int id)
        {
            return _equipments.FirstOrDefault(e => e.Id == id);
        }
        public List<Equipment> GetAllEquipment()
        {
            return _equipments;
        }

        // rentals

        public void AddRental(RentalCard rental) 
        {
            _rentalCards.Add(rental);
        }
        public RentalCard? GetRentalById(int id)
        {
            return _rentalCards.FirstOrDefault(r => r.Id == id);
        }
        public List<RentalCard> GetAllRentals()
        {
            return _rentalCards;
        }

        // Id generation

        public int GeneratePersonId() 
        {
            return _personId++;
        }
        public int GenerateEquipmentId()
        {
            return _equipmentId++;
        }
        public int GenerateRentalId()
        {
            return _rentalId++;
        }
    }
}
