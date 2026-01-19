namespace Application.Municipalities.Dtos
{
    public class MunicipalityResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public int CountryId { get; set; }
    }
}
