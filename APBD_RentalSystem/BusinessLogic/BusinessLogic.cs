using DataModels;
using DataModels.Abstracts;
using DataProcessing;

namespace BusinessLogic
{
    public class BusinessLogic : IBusinessLogic
    {

        private readonly IDataRepository _repository;

        private readonly Dictionary<Type, int> _rentLimits = new()
        {
            { typeof(Student), 2 },
            { typeof(Employee), 5  }
        };

        public BusinessLogic(IDataRepository repository)
        {
            _repository = repository;
        }

        // Person
        public void AddStudent(string firstName, string lastName, decimal averageMark, string major)
        {
            var student = new Student
            {
                Id = _repository.GeneratePersonId(),
                FirstName = firstName,
                LastName = lastName,
                AverageMark = averageMark,
                Major = major
            };

            _repository.AddPerson(student);
        }

        public void AddEmployee(string firstName, string lastName, string position, decimal salary)
        {
            var employee = new Employee
            {
                Id = _repository.GeneratePersonId(),
                FirstName = firstName,
                LastName = lastName,
                Position = position,
                Salary = salary
            };

            _repository.AddPerson(employee);
        }

        public List<Person> GetAllPeople()
        {
            return _repository.GetAllPeople();
        }

        // Equipment

        public void AddLaptop(decimal weight, string modelName, int RAM, int diskSize)
        {
            var laptop = new Laptop
            {
                Id = _repository.GenerateEquipmentId(),
                Weight = weight,
                ModelName = modelName,
                RAM = RAM,
                DiskSize = diskSize
            };
            
            _repository.AddEquipment(laptop);
        }
        public void AddCamera(decimal weight, string modelName, int megaPixels, int memorySize)
        {
            var camera = new Camera
            {
                Id = _repository.GenerateEquipmentId(),
                Weight = weight,
                ModelName = modelName,
                MegaPixels = megaPixels,
                MemorySize = memorySize
            };
            
            _repository.AddEquipment(camera);
        }
        public void AddHeadset(decimal weight, string modelName, bool isWireless, bool hasMicrophone) 
        {
            var headset = new Headset
            {
                Id = _repository.GenerateEquipmentId(),
                Weight = weight,
                ModelName = modelName,
                IsWireless = isWireless,
                HasMicrophone = hasMicrophone
            };

            _repository.AddEquipment(headset);
        }

        public List<Equipment> GetAllEquipment() 
        {
            return _repository.GetAllEquipment();
        }
        public List<Equipment> GetAvailableEquipment() 
        {
            return _repository.GetAllEquipment()
                .Where(e => e.IsAvailable)
                .ToList();
        }

        // renting

        public bool RentEquipment(int personId, int equipmentId, int days)
        {
            var person = _repository.GetPersonById(personId);
            var equipment = _repository.GetEquipmentById(equipmentId);

            if (person == null || equipment == null) 
            { 
                return false;
            }

            if (!equipment.IsAvailable)
            {
                return false;
            }

            int activeRentsForPerson = _repository.GetAllRentals().Count(r => r.Person == person && !r.IsReturned);
            if (activeRentsForPerson >= GetMaxRentsOfPerson(person)) 
            {
                return false; 
            }

            var rental = new RentalCard
            {
                Id = _repository.GenerateRentalId(),
                Person = person,
                Equipment = equipment,
                RentDate = DateOnly.FromDateTime(DateTime.Now),
                DueDate = DateOnly.FromDateTime(DateTime.Now).AddDays(days),
                ReturnDate = null
            };

            equipment.IsAvailable = false;
            _repository.AddRental(rental);

            return true;
        }
        public bool ReturnEquipment(int rentalCardId) 
        {
            var rental = _repository.GetRentalById(rentalCardId);

            if (rental == null || rental.IsReturned)
            {
                return false;
            }

            rental.ReturnDate = DateOnly.FromDateTime(DateTime.Now);
            rental.Equipment.IsAvailable = true;

            return true;
        }

        public List<RentalCard> GetAllRentals() 
        {
            return _repository.GetAllRentals();
        }

        public int GetMaxRentsOfPerson(Person person)
        {
            return _rentLimits.TryGetValue(person.GetType(), out int limit) ? limit : 1;
        }
    }
}
