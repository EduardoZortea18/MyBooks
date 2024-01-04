namespace Application.Dtos
{
    public record BookRequestModel
    {
        public string? Id { get; init; }
        public DateTimeOffset UpdatedAt { get; init; } = DateTimeOffset.Now;
        public bool Active { get; init; }
        public string? Title { get; init; }
        public string? Author { get; init; }
        public double Price { get; init; }
    }
}
