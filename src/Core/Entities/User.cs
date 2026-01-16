namespace Core.Entities
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        public int MunicipalityId { get; private set; }

        public User(string name, string phone, string address, int municipalityId)
        {
            Name = name;
            Phone = phone;
            Address = address;
            MunicipalityId = municipalityId;
        }
    }
}
