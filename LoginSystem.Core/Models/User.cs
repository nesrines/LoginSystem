namespace LoginSystem.Core.Models
{
    public class User : BaseModel
    {
        private static int _id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string Name, string Surname, string Email, string Password)
        {
            _id++;
            Id = _id;
            this.Name = Name;
            this.Surname = Surname;
            this.Email = Email;
            this.Password = Password;
        }
    }
}
