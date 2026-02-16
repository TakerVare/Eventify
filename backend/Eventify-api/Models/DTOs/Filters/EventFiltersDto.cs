namespace Eventify_api.Models.DTOs.Events;

/// <summary>
/// DTO para actualizar evento existente
/// </summary>
public class EventFiltersDto
{
    public string? TextContent { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int LocationId { get; set; }
    public int CategoryId { get; set; }
    public boolean OrderAsc { get; set; }
}
