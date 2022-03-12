# MinimalLinkShortenerAPI

## How to Install Locally

Download repo
Open MinimalLinkShortenerAPP in Visual Studio 
Open appsetting.json and add you connection string. Example below:
"ConnectionStrings": {
    "Default": "Connection String Here"
  }
 Locate and double click LinksDB.publish.xml. This will set the tables in your choose sql database.
 You can then run up the API. Will default to Swagger index page.
 
 ## Endpoints
 
 Found in MinimalLinkShortenerAPI/Api.cs
 
 app.MapGet("/links", GetLinks);
        app.MapGet("/link/{linkName}", GetLink);
        app.MapPost("/links", InsertLink);
        app.MapPut("/Links", UpdateLink);
        app.MapDelete("/links", DeleteLink);
