using BlazorAssessment2.Models;
using BlazorAssessment2.Services.IServices;
using Newtonsoft.Json;

namespace BlazorAssessment2.Services
{
    public class AllServices : IPostInterface, IUserInterface, ICommentInterface
    {
        private readonly HttpClient _httpClient;

        private string _UserUrl = "https://jsonplaceholder.typicode.com/users";
        private string _PostUrl = "https://jsonplaceholder.typicode.com/posts";
        private string _CommentUrl = "https://jsonplaceholder.typicode.com/comments";
        public AllServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Comment>> GetComments()
        {
            var response = await _httpClient.GetAsync(_CommentUrl);
            var content = await response.Content.ReadAsStringAsync();
            var comments = JsonConvert.DeserializeObject<List<Comment>>(content);
            if (response.IsSuccessStatusCode)
            {
                return comments;
            }
            return new List<Comment>();
        }

        public async Task<List<Post>> GetPosts()
        {
            var response = await _httpClient.GetAsync(_PostUrl);
            var content = await response.Content.ReadAsStringAsync();
            var posts = JsonConvert.DeserializeObject<List<Post>>(content);
            if (response.IsSuccessStatusCode)
            {
                return posts;
            }
            return new List<Post>();
        }

        public async Task<List<User>> GetUsers()
        {
            var response = await _httpClient.GetAsync(_UserUrl);
            var content = await response.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<List<User>>(content);
            if (response.IsSuccessStatusCode)
            {
                return users;
            }
            return new List<User>();
        }
    }
}
