namespace MinimalLinkShortenerAPI;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
        //All of API Mapping goes below
        app.MapGet("/users", GetLinks);
        app.MapGet("/users/{linkName}", GetLink);
        app.MapPost("/users", InsertLink);
        app.MapPut("/users", UpdateLink);
        app.MapDelete("/users", DeleteLink);
        
    }

    private static async Task<IResult> GetLinks(ILinkData data)
    {
        try
        {
            return Results.Ok(await data.GetLinks());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetLink(string linkName, ILinkData data)
    {
        try
        {
            var result = await data.GetLink(linkName);
            if (result == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(result);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertLink(LinkModel link, ILinkData data)
    {
        try
        {
            await data.InsertLink(link);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    private static async Task<IResult> UpdateLink(LinkModel link, ILinkData data)
    {
        try
        {
            await data.UpdateLink(link);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    private static async Task<IResult> DeleteLink(string linkName, ILinkData data)
    {
        try
        {
            await data.DeleteLink(linkName);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
