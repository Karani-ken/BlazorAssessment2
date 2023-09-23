using BlazorAssessment2.Models;

namespace BlazorAssessment2.Services.IServices
{
    public interface IUserInterface
    {
        Task<List<User>> GetUsers();
    }
}
