using LoginSystem.Core.Models;
namespace LoginSystem.Data.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        static UserRepository()
        {
            List<User> Users = GetAllAsync();
            Users.Add(new User("Super", "Admin", "admin@gmail.com", "123321"));
        }
        public static bool EmailIsUnique(string Email)
        { return Items.Find(item => item.Email == Email) == null; }
    }
}