using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Models
{
    [Serializable]
    public class Author : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
