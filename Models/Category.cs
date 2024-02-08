namespace Blogv2.Models
{
	public class Category
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        
        public IList<Post> Posts { get; set; }
    }
}