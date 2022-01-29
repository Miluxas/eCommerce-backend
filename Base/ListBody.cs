using Newtonsoft.Json.Linq;

namespace eCommerce_backend.Base
{
    public class ListBody
    {
        public Pagination Pagination { get; set; }=new Pagination();
        public JObject Filter { get; set; } = null;
        public JObject Order { get; set; } = null;
    }
    public class Pagination
    {
        public int Page { get; set; } = 0;
        public int Limit { get; set; } = 10;
    }
}
