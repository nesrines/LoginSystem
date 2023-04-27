using LoginSystem.Data.Repositories;
using System.Text.RegularExpressions;

namespace LoginSystem.Data.Validations
{
    public static class UserValidation
    {
        public static bool CheckName(string Name)
        {
            Regex regex = new Regex("^[A-Z][a-z]{2,29}");
            return regex.IsMatch(Name);
        }

        public static bool CheckSurname(string Surname)
        {
            Regex regex = new Regex("^[A-Z][a-z]{4,19}");
            return regex.IsMatch(Surname);
        }

        public static bool CheckEmail(string Email)
        {
            Regex regex = new Regex("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$");
            return regex.IsMatch(Email);
        }

        public static bool CheckPassword(string Password)
        {
            Regex regex = new Regex("^(?=.*[A-Za-z])(?=.*\\d)(?=.*[@$!%*#?&])[A-Za-z\\d@$!%*#?&]{8,}$");
            return regex.IsMatch(Password);
        }
    }
}