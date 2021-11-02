using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Interfaces
{
    public interface IPublishers
    {
        //Create
        bool CreatePublisher(Publisher publisher);
        bool CreatePublisher(string name);

        //Read
        List<Publisher> GetAllPublishers();
        Publisher GetPublisherById(int id);
        //Update
        bool UpdatePublisher(Publisher publisher);
        //Delete
        bool DeletePublisher(Publisher publisher);
        bool DeletePublisherById(int id);

    }
}
