
namespace ConsoleApp11
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }

        public double TotalPrice { get; set; }
        public int TotalQty { get; set; }
    }
}
