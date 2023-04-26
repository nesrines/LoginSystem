using LoginSystem.Core.Models;

namespace LoginSystem.Data.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        private static readonly List<string> _emails = new List<string>();
        static UserRepository()
        {
            SeedData();
        }
        public static void SeedData()
        {
            var users = GetAllAsync();
            users.Add(new User("Super", "Admin", "admin@gamil.com", "123321"));
        }
        public static bool EmailIsUnique(string Email)
        { return _emails.Find(email => email == Email) == null; }
    }
}