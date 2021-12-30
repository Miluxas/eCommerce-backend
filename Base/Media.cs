using System;
using System.Runtime.Serialization;
using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce_backend.Base
{
    
    public class Media
    {
        public Media()
        {
            this.GuId = Guid.NewGuid();
        }
        public Guid GuId { get; set; }
        public string Url { get; set; }
        public string name { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }

    }
}
