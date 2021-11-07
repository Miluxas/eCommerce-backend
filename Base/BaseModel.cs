using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_backend.Base
{
     
    public class BaseModel
    {

        public Guid ID { get; set; }
        public string ReadableId { get; set; }
        public bool IsActive { get; set; }
        public Guid CountryId { get; set; }

        
    }
}
