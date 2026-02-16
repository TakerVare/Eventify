using Eventify_api.Models.DTOs;
using Eventify_api.Models.Entities.Enum;

namespace Eventify_api.Services.Events;

/// <summary>
/// Interfaz del servicio de eventos
/// </summary>

public interface IEventService
{
    /// <summary>
    /// Obtiene eventos con paginación y filtros avanzados
    /// </summary>
    Task<IEnumerable<EventDto>> GetAlllAsync(EventFiltersDto eventFilterDto);

    /// <summary>
    /// Obtiene un evento por ID con todas las relaciones
    /// </summary>
    Task<EventDto> GetAlllAsync(int id);

    /// <summary>
    /// Obtiene los eventos del organizador actual
    /// </summary>
    Task<IEnumerable<EventDto>> GetMyEventsAsync(int organizerId);

    /// <summary>
    /// Crea un nuevo evento
    /// </summary>
    Task<EventDto> CreateAsync(CreateEventDto createDto, int organizerId);

    /// <summary>
    /// Actualiza un evento existente (solo el organizador o Admin)
    /// </summary>
    Task<EventDto> UpdateAsync(int id, UpdateEventDto updateDto, int currentUserId, string userRole);

    /// <summary>
    /// Elimina un evento (solo el organizador o Admin)
    /// </summary>
    Task DeleteAsync(int id, int currentUserId, string userRole);

    /// <summary>
    /// Publica un evento (cambiar status a Published)
    /// </summary>
    Task<EventDto> PublishEventAsync(int id, int currentUserId, string userRole);

    /// <summary>
    /// Cancela un evento (cambiar status a Cancelled)
    /// </summary>
    Task<EventDto> CancelEventAsync(int id, int currentUserId, string userRole);

    /// <summary>
    /// Obtiene estadísticas de eventos para dashboard
    /// </summary>
    Task<EventStatsDto> GetStatsAsync();



}