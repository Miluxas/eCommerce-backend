using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_backend.Base
{
     
    public class BaseModel
    {
        
        public Int64 ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public Int64 CreatedBy { get; set; }
        public Int16 DeleteStatus { get; set; }


    

    }
}
