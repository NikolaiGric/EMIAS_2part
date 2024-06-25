namespace EMIAS_2part.Model
{
    internal class Admin
    {
        public Admin(string role, string password, string surname, string name, string lastname)
        {
            Role = role;
            Password = password;
            Surname = surname;
            Name = name;
            Lastname = lastname;
        }
        public string Role { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
    }
}
