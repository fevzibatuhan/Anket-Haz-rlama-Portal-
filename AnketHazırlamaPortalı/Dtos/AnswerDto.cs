using AnketHazırlamaPortalı.API.Models;
using AnketHazırlamaPortalı.Models;

namespace AnketHazırlamaPortalı.API.Dtos
{
    public class AnswerDto
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Response { get; set; }

    }
}
