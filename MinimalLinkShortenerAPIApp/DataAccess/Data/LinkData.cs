using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;
public class LinkData : ILinkData
{
    private readonly ISqlDataAccess _db;

    public LinkData(ISqlDataAccess db)
    {
        _db = db;
    }

    /// <summary>
    /// Get all links from database.
    /// Loading it into the IEnumerable and returning to caller.
    /// </summary>
    /// <returns>All links</returns>
    //Passed a empty dynamic as no parameters to pass.
    public Task<IEnumerable<LinkModel>> GetLinks() =>
        _db.LoadData<LinkModel, dynamic>("dbo.spLink_GetAll", new { });

    /// <summary>
    /// Get single Link of linkname
    /// </summary>
    /// <param name="linkName">The link name of desired link</param>
    /// <returns>LinkName,LinkURL, LinkDescription, CreatedAt, UpdatedOn. Or if Link cannot be found
    /// returns NULL</returns>
    public async Task<LinkURLModel?> GetLink(string linkName)
    {
        var results = await _db.LoadData<LinkURLModel, dynamic>(
            "dbo.spLink_Get",
            new { LinkName = linkName });
        return results.FirstOrDefault();
    }

    /// <summary>
    /// Enters the data to the database
    /// </summary>
    /// <param name="link">LinkModel</param>
    /// <returns></returns>
    public Task InsertLink(LinkModel link) =>
        _db.SaveData("dbo.spLink_Insert", new { link.LinkName, link.LinkURL, link.LinkDescription });

    /// <summary>
    /// Update specified Link
    /// </summary>
    /// <param name="link">LinkModel</param>
    /// <returns></returns>
    public Task UpdateLink(LinkModel link) =>
        _db.SaveData("dbo.spLink_Update", link);

    // <summary>
    /// Deletes specified Link
    /// </summary>
    /// <param name="link">LinkModel</param>
    /// <returns></returns>
    public Task DeleteLink(string linkName) =>
        _db.SaveData("dbo.spLink_Delete", new { linkName });
}

