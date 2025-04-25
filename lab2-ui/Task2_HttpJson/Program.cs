using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
    }

    static async Task Main()
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/2");

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            Post? post = JsonSerializer.Deserialize<Post>(json, options);
            if (post != null)
            {
                Console.WriteLine("Post ID: " + post.Id);
                Console.WriteLine("Post Title: " + post.Title);
            }
            else
            {
                Console.WriteLine("Deserialization failed. Post is null.");
            }
        }
        else
        {
            Console.WriteLine("Error: " + response.StatusCode);
        }
    }
}