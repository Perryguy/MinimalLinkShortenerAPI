using LinkShortenerFrontend.Models;

namespace LinkShortenerFrontend.Services
{
    public interface ILinkService
    {
        HttpClient HttpClient { get; }

        Task<IEnumerable<LinkModel>> GetLinks();
    }
}