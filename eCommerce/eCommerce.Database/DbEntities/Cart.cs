namespace eCommerce.Database.DbEntities
{
    public class Cart
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Product> Products { get; set; }
        
    }
}