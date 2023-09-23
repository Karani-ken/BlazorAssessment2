using BlazorAssessment2.Models;

namespace BlazorAssessment2.Services.IServices
{
    public interface ICommentInterface
    {
        Task<List<Comment>> GetComments();
    }
}
