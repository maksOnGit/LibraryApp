using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Models
{
    [Serializable]
    public class Publisher : BaseModel
    {
        public string PublisherName { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Publisher publisher &&
                   PublisherName == publisher.PublisherName;
        }

        public override int GetHashCode()
        {
            return 1054981532 + EqualityComparer<string>.Default.GetHashCode(PublisherName);
        }
    }
}
