using System.ComponentModel.DataAnnotations;
using eCommerce.Infrastructure.Types.Enums;

namespace eCommerce.Database.DbEntities
{
    public class User
    {
        [Key] 
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public UserType Type { get; set; }
        public Currency Currency { get; set; }
    }
}