namespace eCommerce_backend.Base
{
    public class ListBody
    {
        public int Page { get; set; } = 0;
        public int Limit { get; set; } = 10;
        public string Filter { get; set; } = null;
    }
}
