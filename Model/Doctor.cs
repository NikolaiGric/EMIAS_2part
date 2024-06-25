namespace EMIAS_2part.Model
{
    internal class Doctor
    {
        public Doctor(string role, string password, string surname, string name, string lastname, DateTime doctorspecialty, string address)
        {
            Role = role;
            Password = password;
            Surname = surname;
            Name = name;
            Lastname = lastname;
            DoctorSpecialty = doctorspecialty;
            Address = address;
        }
        public string Role { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime DoctorSpecialty { get; set; }
        public string Address { get; set; }
    }
}