namespace LinkShortenerFrontend.Models;

public class LinkModel
{
    public int Id { get; set; }
    public string? LinkName { get; set; }
    public string? LinkURL { get; set; }
    public string? LinkDescription { get; set; }
    public string? CreatedAt { get; set; }
    public string? UpdatedOn { get; set; }
    public int Hits { get; set; }
}

