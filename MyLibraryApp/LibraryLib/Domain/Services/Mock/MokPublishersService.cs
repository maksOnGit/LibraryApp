﻿using LibraryLib.Data;
using LibraryLib.Domain.Interfaces;
using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Services.Mock
{
    public class MokPublishersService : IPublishers
    {
        public bool CreatePublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public bool CreatePublisher(string name)
        {
            throw new NotImplementedException();
        }

        public bool DeletePublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public bool DeletePublisherById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Publisher> GetAllPublishers()
        {
            return MockDataSeeder.Publishers;
        }

        public Publisher GetPublisherById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }
    }
}
