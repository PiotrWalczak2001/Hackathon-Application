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

        public async Task TakeFakeData()
        {
            string relativeUri = $"{_httpClient.BaseAddress}/takeAllFakeSurveyss";

            var data = await JsonSerializer.DeserializeAsync<ICollection<FakeDataListViewModel>>(
                await _httpClient.GetStreamAsync(relativeUri),
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            _mapper.Map<List<FakeDataListViewModel>>(data);
        }
    }
}
