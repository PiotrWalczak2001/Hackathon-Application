﻿using System;

namespace HA.Domain.Enitites
{
    public class SurveySecond
    {
        public Guid Id { get; set; }
        public string Survey { get; set; }
        public Guid ZoneId { get; set; }
        public DateTime SurveyDate { get; set; }
    }
}
