using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary;
using System.ComponentModel.DataAnnotations;

namespace BikeShop.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "Enter the client name.")]
        public string Name { get; set; }
        public string Document { get; set; }

        [Required(ErrorMessage = "Enter the client's phone number .")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Client(int id)
        {
            Id = id;
        }

        public Client()
        {
        }
    }
}
