using AnketHazırlamaPortalı.API.Models;
using AnketHazırlamaPortalı.Models;
using Microsoft.Extensions.Options;

namespace AnketHazırlamaPortalı.API.Dtos
{
    public class QuestionDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        
        public int SurveyId { get; set; }
        
    }
}
