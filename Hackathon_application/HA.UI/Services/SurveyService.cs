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
    public class SurveyService : ISurveyService
    {
        private readonly IMapper _mapper;
        private readonly HttpClient _httpClient;
        public SurveyService(HttpClient httpClient, IMapper mapper)
        {
            _httpClient = httpClient;
            _mapper = mapper;
        }

        public async Task<List<ZoneListViewModel>> TakeFakeData()
        {
            string relativeUri = $"{_httpClient.BaseAddress}/takeAllFakeSurveys";

            var data = await JsonSerializer.DeserializeAsync<ICollection<ZoneListViewModel>>(
                await _httpClient.GetStreamAsync(relativeUri),
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

           return _mapper.Map<List<ZoneListViewModel>>(data);

        }
    }
}
