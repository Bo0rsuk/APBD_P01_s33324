using DataModels;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;
using DataModels.Abstracts;


namespace DataProcessing
{

    // make it singleton
    public class DataRepository : IDataRepository
    {
        private static List<Person> persons = new List<Person>();
        private static List<Equipment> equipments = new List<Equipment>();
        private static List<RentalCard> rentalCards = new List<RentalCard>();

    }
}
