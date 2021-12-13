using System;
using ExEnumeracao2.Entities.Enum;

namespace ExEnumeracao2.Entities
{
    //Cliente
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        //Construtor vazio
        public Client()
        {

        }
        //Construtor com 3 parâmetros
        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

       
    }
}
