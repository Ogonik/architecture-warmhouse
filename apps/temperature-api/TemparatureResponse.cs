namespace temperature_api
{
    public record TemparatureResponseDTO
    {
        public double Value { get; init; }

        public string? Unit { get; init; }

        public DateTime Timestamp { get; init; }

        public string? Location { get; init; }

        public string? Status { get; init; }

        public string? SensorId { get; init; }

        public string? SensorType { get; init; }

        public string? Description { get; init; }
    }
}
