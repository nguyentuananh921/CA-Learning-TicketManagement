using Application.Contracts.Persistence;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);
    }
}
