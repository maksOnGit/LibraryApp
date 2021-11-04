using LibraryLib.Data;
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
            // IMPLEMENT EQUALS AND HASHCODE IN Publisher Class ! If not, the next checker will not work !
            if (!GetAllPublishers().Contains(publisher))
            {
                MockDataSeeder.Publishers.Add(publisher);
                return MockDataSeeder.Publishers.Contains(publisher);
            }
            return false;
        }

        public bool CreatePublisher(string name)
        {
            if (name != string.Empty)
            {
                Publisher newPublisher = new Publisher
                {
                    ID = GetAllPublishers().Count,
                    PublisherName = name,
                };
                    return CreatePublisher(newPublisher);
            }
            return false;


            //newPublisher.PublisherName = name;
            //newPublisher.ID = GetAllPublishers().Count;
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
