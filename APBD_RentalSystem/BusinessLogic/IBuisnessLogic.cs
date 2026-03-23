using DataModels;
using DataModels.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public interface IBuisnessLogic
    {
        // for Person
        void AddStudent(string firstName, string lastName, decimal averageMark, string major);
        void AddEmployee(string firstName, string lastName, string position, decimal salary);
        List<Person> GetAllPeople();

        // for Equipment

        void AddLaptop(decimal weight, string modelName, int RAM, int diskSize);
        void AddCamera(decimal weight, string modelName, int megaPixels, int memorySize);
        void AddHeadset(decimal weight, string modelName, bool isWireless, bool hasMicrophone);
        List<Equipment> GetAllEquipment();
        List<Equipment> GetAvailableEquipment();

        // for renting
        bool RentEquipment(int personId, int equipmentId, int days);
        bool ReturnEquipment(int rentalCardId);
        List<RentalCard> GetAllRentals();

        // helper
        int GetMaxRentsOfPerson(Person person);
    }
}
