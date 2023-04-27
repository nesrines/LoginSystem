using LoginSystem.Core.Models;
using LoginSystem.Data.Repositories;
using LoginSystem.Data.Validations;
namespace LoginSystem.Data.Authentications
{
    public class UserAuthentication
    {
        public async Task Register()
        {
            string Name = GetName();
            string Surname = GetSurname();
            string Email = GetEmail();
            string Password = GetPassword();
            User User = new User(Name, Surname, Email, Password);
            UserRepository.CreateAsync(User);
            Console.WriteLine("Your account is created successfully. You can login now.");
        }

        public async Task Login()
        {
            Console.Write("Enter your email: ");
            string Email = Console.ReadLine().Trim();
            while (!UserValidation.CheckEmail(Email) && UserRepository.EmailIsUnique(Email))
            {
                Console.Write("Enter a valid email: ");
                Email = Console.ReadLine().Trim();
            }
            Console.Write("Enter your password: ");
            string Password = Console.ReadLine().Trim();
            User Result = UserRepository.GetAllAsync().Find(user => user.Password == Password);
            if (Result != null)
            { Console.WriteLine($"Welcome to your account, {Result.Name} {Result.Surname}!"); }
            else { Console.WriteLine("Incorrect password"); }
        }

        private string GetName()
        {
            Console.Write("Enter your name: ");
            string NewName = Console.ReadLine().Trim();
            while (!UserValidation.CheckSurname(NewName))
            {
                Console.Write("Enter a valid name: ");
                NewName = Console.ReadLine().Trim();
            }
            return NewName;
        }

        private string GetSurname()
        {
            Console.Write("Enter your surname: ");
            string NewSurname = Console.ReadLine().Trim();
            while (!UserValidation.CheckSurname(NewSurname))
            {
                Console.Write("Enter a valid surname: ");
                NewSurname = Console.ReadLine().Trim();
            }
            return NewSurname;
        }

        private string GetEmail()
        {
            Console.Write("Enter your email: ");
            string NewEmail = Console.ReadLine().Trim();
            while (UserRepository.EmailIsUnique(NewEmail) && !(UserValidation.CheckEmail(NewEmail)))
            {
                Console.Write("Enter a valid email: ");
                NewEmail = Console.ReadLine().Trim();
            }
            return NewEmail;
        }

        private string GetPassword()
        {
            Console.Write("Create a password: ");
            string NewPassword = Console.ReadLine().Trim();
            while (!UserValidation.CheckPassword(NewPassword))
            {
                Console.WriteLine("Your password must have at least:");
                Console.WriteLine("8 characters (20 max)");
                Console.WriteLine("1 letter and 1 number");
                Console.WriteLine("1 special character");
                Console.Write("Enter a valid password: ");
                NewPassword = Console.ReadLine().Trim();
            }
            Console.Write("Confirm your password: ");
            string Password = Console.ReadLine().Trim();
            while (Password != NewPassword)
            {
                Console.WriteLine("Passwords don't match");
                Console.Write("Confirm your password: ");
                Password = Console.ReadLine().Trim();
            }
            return NewPassword;
        }
    }
}