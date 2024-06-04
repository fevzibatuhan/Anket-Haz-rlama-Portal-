﻿using AnketHazırlamaPortalı.Models;

namespace AnketHazırlamaPortalı.API.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        

        public int SurveyId { get; set; }

        public Survey Survey { get; set; }

        public List<Answer> Answers { get; set; }
    }
}
