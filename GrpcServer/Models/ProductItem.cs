namespace GrpcServer.Models
{
    public class ProductItem
    {
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public required string ProductDescription { get; set; }
        public double ProductPrice { get; set; }

    }
}
