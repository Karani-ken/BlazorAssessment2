using BlazorAssessment2.Models;

namespace BlazorAssessment2.Services.IServices
{
    public interface IPostInterface
    {
        Task<List<Post>> GetPosts();
    }
}
