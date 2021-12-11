using AutoMapper;
using HA.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace HA.UI.Services
{
    public class ZoneService : IZoneService
    {
        private readonly IMapper _mapper;
        private readonly HttpClient _httpClient;
        public ZoneService(HttpClient httpClient, IMapper mapper)
        {
            _httpClient = httpClient;
            _mapper = mapper;
        }

        public async Task<List<ZoneListViewModel>> GetAllZones()
        {
            string relativeUri = $"{_httpClient.BaseAddress}/all";

            var allZones = await JsonSerializer.DeserializeAsync<ICollection<ZoneListViewModel>>(
                await _httpClient.GetStreamAsync(relativeUri),
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            var mappedBooks = _mapper.Map<List<ZoneListViewModel>>(allZones);
            return mappedBooks;
        }
    }
}
