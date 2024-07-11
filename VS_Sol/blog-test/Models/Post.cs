namespace blog_test.Models
{
    public class Post
    {

        public int PostId { get; set; }

        public int BlogId { get; set; }

        public int AuthorId { get; set; }

        public string PostTitle { get; set; }

        public string PostBody { get; set; }

        public Post()
        {
            
        }
    }
}
