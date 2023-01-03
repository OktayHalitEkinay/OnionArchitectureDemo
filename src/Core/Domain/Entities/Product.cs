using Domain.Common;


namespace Domain.Entities
{
    public class Product : BaseEntitiy
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
