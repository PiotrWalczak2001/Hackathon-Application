using System;

namespace HA.Application.Features.Surveys.First.Queries.TakeFakeSurveyFirst
{
    public class FakeSurveyFirstVm
    {
        public Guid Id { get; set; }
        public string Survey { get; set; }
        public Guid ZoneId { get; set; }
        public DateTime SurveyDate { get; set; }
    }
}
