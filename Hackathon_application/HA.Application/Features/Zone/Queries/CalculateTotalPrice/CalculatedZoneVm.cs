using System;

namespace HA.Application.Features.Zone.Queries.CalculateTotalPrice
{
    public class CalculatedZoneVm
    {
        public Guid Id { get; set; }
        public string ZoneName { get; set; }
        public decimal DefaultPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public Guid SurveyFirstId { get; set; }
        public Guid SurveySecondId { get; set; }
    }
}
