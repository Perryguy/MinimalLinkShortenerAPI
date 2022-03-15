using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.JSInterop;
using LinkShortenerFrontend;
using LinkShortenerFrontend.Shared;
using LinkShortenerFrontend.Models;
using LinkShortenerFrontend.Services;

namespace LinkShortenerFrontend.Pages
{
    public partial class LinkData
    {
        List<LinkModel>? links;
        string? errorString;
        protected override async Task OnInitializedAsync()
        {
            errorString = null;
            try
            {
                links = (await LinkService.GetLinks()).ToList();
            }
            catch (Exception e)
            {
                errorString = "Error fetching data: " + e.Source;
            }      
        }
    }
}