using System;
using System.Collections.Generic;

namespace GuideAutoMapper.Models
{
    public class ClientRepository
    {
        private readonly List<Client> clients = new List<Client>() 
        { 
            new Client(){ 
                ClientId = 1, 
                Name = "Julio", 
                Email="julito_gtu@hotmail.com", 
                CreationDate = DateTime.Now, 
                Password = "123456"},
            new Client(){ 
                ClientId = 2, 
                Name = "Juank", 
                Email="juank@hotmail.com", 
                CreationDate = DateTime.Now, 
                Password = "123456"}
        };

        public ClientViewModel GetById(int id)
        {
            //Get the client
            var client = clients[0];
            //Define the mapping
            AutoMapper.Mapper.CreateMap<Client, ClientViewModel>();
            //Execute the mapping
            var clientViewModel = AutoMapper.Mapper.Map<Client, ClientViewModel>(client);
            //Return a viewmodel
            return clientViewModel;
        }

        public ClientViewModel GetByIdWithProfile(int id)
        {
            //Get the client
            var client = clients[0];
            //Execute the mapping
            var clientViewModel = AutoMapper.Mapper.Map<Client, ClientViewModel>(client);
            //Return a viewmodel
            return clientViewModel;
        }

        public IEnumerable<ClientViewModel> GetAll()
        {
            //Execute the mapping
            var clientViewModel = AutoMapper.Mapper
                                .Map<IEnumerable<Client>, IEnumerable<ClientViewModel>>(clients);
            //Return a viewmodel
            return clientViewModel;
        }
    }
}