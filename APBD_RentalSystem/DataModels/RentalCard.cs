using DataModels.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class RentalCard
    {
        public int Id { get; set; }
        public Equipment Equipment { get; set; }
        public Person Person { get; set; }
        public DateOnly RentDate { get; set; }
        public DateOnly DueDate { get; set; }
        public bool IsReturned { get; set; } = false;
        public DateOnly? ReturnDate { get; set; }

        public RentalCard() { }

        public RentalCard(int id, Equipment equipment, Person person, DateOnly rentDate, DateOnly dueDate, DateOnly returnDate)
        {
            Id = id;
            Equipment = equipment;
            Person = person;
            RentDate = rentDate;
            DueDate = dueDate;
            ReturnDate = returnDate;
        }
    }
}
