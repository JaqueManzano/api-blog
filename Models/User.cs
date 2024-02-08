using System.Text.Json.Serialization;

namespace Blogv2.Models
{
	public class User
    {
        public int Id { get; set; } = 0;    
        public string Name { get; set; } = string.Empty;    
        public string Email { get; set; } = string.Empty;
        [JsonIgnore]
        public string PasswordHash { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;

        public IList<Post> Posts { get; set; }
        public IList<Role> Roles { get; set; }
    }
}