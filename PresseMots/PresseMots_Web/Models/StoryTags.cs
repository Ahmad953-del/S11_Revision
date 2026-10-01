using System.ComponentModel.DataAnnotations.Schema;

namespace PresseMots.Models
{
    public class StoryTags
    {
        public int Id { get; set; }
        [ForeignKey("Tag")]
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
        [ForeignKey("Story")]
        public int StoryId { get; set; }
        public virtual Story Story { get; set; }

    }
}
