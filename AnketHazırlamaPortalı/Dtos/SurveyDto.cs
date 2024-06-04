﻿using AnketHazırlamaPortalı.Models;

namespace AnketHazırlamaPortalı.Dtos
{
    public class SurveyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }

        public int CategoryId { get; set; }
        
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        

    }
}
