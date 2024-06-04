using AnketHazırlamaPortalı.Models;

namespace AnketHazırlamaPortalı.API.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Response { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Question Question { get; set; }
    }
}
