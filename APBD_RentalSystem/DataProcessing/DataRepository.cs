using DataModels;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataProcessing
{
    public class DataRepository
    {
        private List<Person> persons = new List<Person>();
        private List<Equipment> equipments = new List<Equipment>();
        private List<RentalCard> rentalCards = new List<RentalCard>();

        private IBuisnessLogic buisnessLogic;

        public DataRepository(IBuisnessLogic buisnessLogic)
        {
            this.buisnessLogic = buisnessLogic;
        }
    }
}
