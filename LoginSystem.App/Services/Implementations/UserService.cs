using LoginSystem.App.Services.Interfaces;
using LoginSystem.Data.Authentications;

namespace LoginSystem.App.Services.Implementations
{
    public class UserService : IUserService
    {
        UserAuthentication UserAuthenticator = new UserAuthentication();
        public void Login()
        { UserAuthenticator.Login(); }

        public void Register()
        { UserAuthenticator.Register(); }
    }
}