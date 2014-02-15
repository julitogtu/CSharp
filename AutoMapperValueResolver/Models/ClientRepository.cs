using System;
using System.Collections.Generic;
using AutoMapperValueResolver.Models;

namespace AutoMapperValueResolver.Models
{
    public class ClientRepository
    {
        private readonly List<Client> clients = new List<Client>() 
        { 
            new Client(){ 
                ClientId = 1, 
                Name = "Julio", 
                LastName = "Avellaneda",
                Email="julito_gtu@hotmail.com", 
                CreationDate = DateTime.Now, 
                Password = "123456"},
            new Client(){ 
                ClientId = 2, 
                Name = "Juank", 
                LastName = "Ruiz",
                Email="juank@hotmail.com", 
                CreationDate = DateTime.Now, 
                Password = "123456"}
        };

        public AutoMapperValueResolver.Models.ClientViewModel GetById(int id)
        {
            //Get the client
            var client = clients[0];
            //Define the mapping
            AutoMapper.Mapper.CreateMap<Client, AutoMapperValueResolver.Models.ClientViewModel>();
            //Execute the mapping
            var clientViewModel = AutoMapper.Mapper.Map<Client, AutoMapperValueResolver.Models.ClientViewModel>(client);
            //Return a viewmodel
            return clientViewModel;
        }

        public AutoMapperValueResolver.Models.ClientViewModel GetByIdWithProfile(int id)
        {
            //Get the client
            var client = clients[0];
            //Execute the mapping
            var clientViewModel = AutoMapper.Mapper.Map<Client, AutoMapperValueResolver.Models.ClientViewModel>(client);
            //Return a viewmodel
            return clientViewModel;
        }

        public IEnumerable<AutoMapperValueResolver.Models.ClientViewModel> GetAll()
        {
            //Execute the mapping
            var clientViewModel = AutoMapper.Mapper
                                            .Map<IEnumerable<Client>, IEnumerable<AutoMapperValueResolver.Models.ClientViewModel>>(clients);
            //Return a viewmodel
            return clientViewModel;
        }
    }
}