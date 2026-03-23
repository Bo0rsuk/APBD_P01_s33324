using DataModels;
using DataModels.Abstracts;

namespace DataProcessing
{
    public interface IDataRepository
    {
        //add CRUD methods here
        // for Person
        void AddPerson(Person person);
        Person? GetPersonById(int id);
        List<Person> GetAllPeople();

        //for Equipment
        void AddEquipment(Equipment equipment);
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