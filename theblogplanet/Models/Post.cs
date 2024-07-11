using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace theblogplanet.Models
{
    public class Post
    {

        public int PostId { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "The title must be 2-60 characters."), ]
        public string PostTitle { get; set; }

        [Required]
        [StringLength(1500, MinimumLength = 20, ErrorMessage = "Posts must be 20-1500 characters.")]
        public string PostContent { get; set; }

        public int UserId { get; set; }

        public string UserName { get; set; }

        public Post()
        {
            
        }
    }
}
