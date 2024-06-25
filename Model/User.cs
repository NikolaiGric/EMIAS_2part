namespace EMIAS_2part.Model
{
    public class User
    {
        public User(string role, string policynumber, string surname, string name, string lastname, string dateofbirth, string address)
        {
            Role = role;
            PolicyNumber = policynumber;
            Surname = surname;
            Name = name;
            Lastname = lastname;
            DateOfBirth = dateofbirth;
            Address = address;
        }
        public string Role { get; set; }
        public string PolicyNumber { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
    }
}
