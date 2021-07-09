// namespace API.Entities
// {
//     public class AppUser
//     {
//      public int Id { get; set; }
//      public int UserName { get; set; }

//      public byte[] PasswordHash { get; set; }
//      public byte[] PasswordSalt { get; set; }
        
//     }
// }
namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
               
    }
}