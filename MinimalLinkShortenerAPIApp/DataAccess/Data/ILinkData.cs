using DataAccess.Models;

namespace DataAccess.Data;

public interface ILinkData
{
    Task<IEnumerable<LinkModel>> GetLinks();
    Task DeleteLink(LinkModel link);
    Task<LinkModel?> GetLink(string linkName);
    Task InsertLink(LinkModel link);
    Task UpdateLink(LinkModel link);
}