using System;
using System.Collections.Generic;

namespace AutoMapper.Models
{
    public class ClientRepository
    {
        private readonly List<Client> clients = new List<Client>() 
        { 
            new Client(){ ClientId = 1, Name = "Julio", LastName = "Avellaneda", Email="julito_gtu@hotmail.com", CreationDate = DateTime.Now, Password = "123456"}
        };

        public ClientViewModel GetClientViewModelById(int id)
        {
            //Get a client
            var client = clients[0];

            //Define the mapping
            AutoMapper.Mapper.CreateMap<Client, ClientViewModel>();
            //Execute a map
            var clientvm = AutoMapper.Mapper.Map<Client, ClientViewModel>(client);
            //Return an instance of ClientViewModel
            return clientvm;
        }
    }
}