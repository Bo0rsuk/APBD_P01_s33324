using DataModels;
using DataModels.Abstracts;

namespace DataProcessing
{
    public interface IDataRepository
    {
        // for Person
        void AddPerson(Person person);
        Person? GetPersonById(int id);
        List<Person> GetAllPeople();

        //for Equipment
        void AddEquipment(Equipment equipment);
        void UpdateEquipmentAvailability(int id);
        Equipment? GetEquipmentById(int id);
        List<Equipment> GetAllEquipment();

        // for rentals
        void AddRental(RentalCard rental);
        RentalCard? GetRentalById(int id);
        List<RentalCard> GetAllRentals();

        // auto Id generation
        int GeneratePersonId();
        int GenerateEquipmentId();
        int GenerateRentalId();
    }
}