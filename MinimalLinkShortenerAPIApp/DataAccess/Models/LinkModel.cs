using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;
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
