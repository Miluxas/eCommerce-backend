using System;
using System.Runtime.Serialization;


namespace eCommerce_backend.Base
{
    public class Media
    {
        public Media()
        {
            this.GuID = Guid.NewGuid();
        }
        public Guid GuID { get; set; }
        public string Url { get; set; }
        public string name { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }

    }
}
