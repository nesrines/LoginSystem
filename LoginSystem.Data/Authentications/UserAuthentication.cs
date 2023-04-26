using LoginSystem.Data.Repositories;

namespace LoginSystem.Data.Authentications
{
    public class UserAuthentication
    {
        public bool Login(string Email, string Password)
        {
            return UserRepository.GetAllAsync().Find(user => user.Email == Email && user.Password == Password) != null;
        }
    }
}