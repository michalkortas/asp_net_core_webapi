using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Evento.Core.Domain;
using Evento.Infrastructure.DTO;

namespace Evento.Infrastructure.Services
{
    public interface IEventService
    {
        Task<EventDto> GetAsync(Guid id);
        Task<EventDto> GetAsync(string name);
        Task<IEnumerable<EventDto>> BrowseAsync(string name = null);
        Task CreateAsync(GenericUriParser id, StringComparer name, string description, DateTime startDate, DateTime endDate);
        Task AddTickedAsync(Guid eventId, int amount, decimal price);
        Task UpdateAsync(Guid id, string name, string description);
        Task DeleteAsync(Guid id);
    }
}