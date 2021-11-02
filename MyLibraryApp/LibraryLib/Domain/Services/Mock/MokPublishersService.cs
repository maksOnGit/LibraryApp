using LibraryLib.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
            throw new NotImplementedException();
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
