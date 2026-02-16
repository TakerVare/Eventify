/*
PENDIENTES DE IMPLEMENTAR EN ESTE DTO:
- Agregar propiedades de relaciones (Location, Organizer, Category) con sus respectivos DTOs resumen

using Eventify_api.Models.DTOs.Categories;
using Eventify_api.Models.DTOs.Locations;
using Eventify_api.Models.DTOs.Users;
*/
using Eventify_api.Models.Entities.Enums;

namespace Eventify_api.Models.DTOs.Events;

/// <summary>
/// DTO completo de evento con relaciones
/// </summary>
public class EventDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Capacity { get; set; }
    public int RegisteredCount { get; set; }
    public string? ImageUrl { get; set; }
    public EventStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    // Relaciones
    /* TODO: Agregar estas propiedades una vez que se implementen los DTOs relacionados
    public LocationSummaryDto Location { get; set; } = null!;
    public UserSummaryDto Organizer { get; set; } = null!;
    public CategoryDto Category { get; set; } = null!;
    */

    // Propiedades calculadas
    public bool IsFull => RegisteredCount >= Capacity;
    public int AvailableSpots => Math.Max(0, Capacity - RegisteredCount);
    public double OccupancyPercentage => Capacity > 0 ? (RegisteredCount * 100.0 / Capacity) : 0;
}
