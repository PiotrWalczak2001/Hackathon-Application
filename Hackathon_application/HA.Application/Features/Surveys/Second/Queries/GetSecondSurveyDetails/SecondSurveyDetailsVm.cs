using System;

namespace HA.Application.Features.Surveys.Second.Queries.GetFirstSurveyDetails
{
    public class SecondSurveyDetailsVm
    {
        public Guid Id { get; set; }
        public string Survey { get; set; }
        public Guid ZoneId { get; set; }
        public DateTime SurveyDate { get; set; }

    }
}
