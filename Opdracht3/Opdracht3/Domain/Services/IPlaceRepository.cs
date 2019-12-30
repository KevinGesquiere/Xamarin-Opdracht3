using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opdracht3.Domain.Models;
namespace Opdracht3.Domain.Services
{
    public interface IPlaceRepository
    {
        bool DatastoreExists { get; }
        Task<IQueryable<Place>> GetAll();
        Task<Place> GetPlace(Guid id);
        Task<Place> UpdatePlace(Place location);
        Task<Place> AddPlace(Place location);
        Task<Place> DeletePlace(Guid id);
    }
}
