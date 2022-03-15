using LinkShortenerFrontend.Models;

namespace LinkShortenerFrontend.Services
{
    public interface ILinkService
    {
        Task<IEnumerable<LinkModel>> GetLinks();
    }
}