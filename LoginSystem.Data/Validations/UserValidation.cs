using LoginSystem.Data.Repositories;
using System.Text.RegularExpressions;

namespace LoginSystem.Core.Validations
{
    public static class UserValidation
    {
        public static async Task<bool> CheckName(string Name)
        {
            Regex regex = new Regex("^[A-Z][a-z]{2,29}");
            return regex.IsMatch(Name);
        }

        public static async Task<bool> CheckSurname(string Surname)
        {
            Regex regex = new Regex("^[A-Z][a-z]{4,19}");
            return regex.IsMatch(Surname);
        }

        public static async Task<bool> CheckEmail(string Email)
        {
            Regex regex = new Regex("/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*$/.");
            return regex.IsMatch(Email) && UserRepository.EmailIsUnique(Email); ;
        }

        public static async Task<bool> CheckPassword(string Password)
        {
            Regex regex = new Regex("(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$\"");
            return regex.IsMatch(Password);
        }
    }
}