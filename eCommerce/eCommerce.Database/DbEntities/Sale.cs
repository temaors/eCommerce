namespace eCommerce.Database.DbEntities
{
    public class Sale
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Product> Products { get; set; }
        public double Price { get; set; }
    }
}