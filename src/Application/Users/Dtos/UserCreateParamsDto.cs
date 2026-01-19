namespace Application.Users.Dtos
{
    public class UserCreateParamsDto
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int MunicipalityId { get; set; }
    }
}
