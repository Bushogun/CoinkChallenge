namespace Application.Users.Dtos
{
    public class UserResponseDto
    {
        public string IdUser { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string Address { get; set; } = default!;
        public int MunicipalityId { get; set; }
    }
}