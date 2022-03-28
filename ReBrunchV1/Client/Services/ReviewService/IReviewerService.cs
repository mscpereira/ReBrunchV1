using ReBrunchV1.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReBrunchV1.Client.Services
{
    public interface IReviewerService
    {
        Task<List<Reviewer>> GetReviewers();
        Task<Reviewer> GetReviewerById(int id);
    }
}
