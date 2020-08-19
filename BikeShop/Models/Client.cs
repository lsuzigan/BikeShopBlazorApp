using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary;

namespace BikeShop.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public async Task CreateNewClient(Client newClient)
        {
            DataAccess _db = new DataAccess();

            string sql = @"insert into `bikeshop`.`client` (`name`, `document`, `phone_number`, `email`)
                            values (@newClient.Name, @newClient.Document, @newClient.PhoneNumber, @newClient.Email);";

            await _db.SaveData(sql, newClient, "default");
        }
    }
}
