using DataModels.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class RentalCard
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public int PersonId { get; set; }
        public DateOnly RentDate { get; set; }
        public DateOnly DueDate { get; set; }
        public bool IsReturned { get; set; } = false;
        public DateOnly? ReturnDate { get; set; }

        public RentalCard() { }

        public RentalCard(int id, int equipmentId, int personId, DateOnly rentDate, DateOnly dueDate, DateOnly returnDate)
        {
            Id = id;
            EquipmentId = equipmentId;
            PersonId = personId;
            RentDate = rentDate;
            DueDate = dueDate;
            ReturnDate = returnDate;
        }
    }
}
