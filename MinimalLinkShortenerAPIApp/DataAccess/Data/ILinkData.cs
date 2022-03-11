using DataAccess.Models;

namespace DataAccess.Data;

public interface ILinkData
{
    Task<IEnumerable<LinkModel>> GetLinks();
    Task DeleteLink(string linkName);
    Task<LinkModel?> GetLink(string linkName);
    Task InsertLink(LinkModel link);
    Task UpdateLink(LinkModel link);
}