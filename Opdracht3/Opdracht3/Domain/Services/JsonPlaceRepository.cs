using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Opdracht3.Domain.Models;
using Newtonsoft.Json;

namespace Opdracht3.Domain.Services
{
    public class JsonLocationRepository : IPlaceRepository
    {
        private readonly string _filePath;

        public JsonLocationRepository()
        {
            _filePath = Path.Combine(FileSystem.AppDataDirectory, "places.json");
        }

        public bool DatastoreExists => throw new NotImplementedException();

        public async Task<IQueryable<Place>> GetAll()
        {
            try {
                string placesJson = File.ReadAllText(_filePath);
                var places = JsonConvert.DeserializeObject<IEnumerable<Place>>(placesJson);
                var placesQuery = places.AsQueryable();
                return await Task.FromResult(placesQuery);
            }
            catch {
                return (new List<Place>()).AsQueryable();
            }
        }
        public async Task<Place> GetPlace(Guid id)
        {
            var allPlaces = await GetAll();
            return allPlaces.FirstOrDefault(e => e.Id == id);
        }

        public async Task<Place> AddPlace(Place place)
        {
            var allPlaces = (await GetAll()).ToList();
            allPlaces.Add(place);
            SavePlacesToFile(allPlaces);
            return await GetPlace(place.Id);
        }

        public async Task<Place> UpdatePlace(Place place)
        {
            await DeletePlace(place.Id);
            return await AddPlace(place);
        }

        public async Task<Place> DeletePlace(Guid id)
        {
            var allPlaces = (await GetAll()).ToList();
            var placeToRemove = allPlaces.FirstOrDefault(e => e.Id == id);
            allPlaces.Remove(placeToRemove);
            SavePlacesToFile(allPlaces);
            return placeToRemove;
        }

        protected void SavePlacesToFile(IEnumerable<Place> places)
        {
            string placesJson = JsonConvert.SerializeObject(places);
            File.WriteAllText(_filePath, placesJson);
        }
    }
}
