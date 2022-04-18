using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace BlazorStaticWebApps.Pages
{
    public partial class Index
    {
        [Inject]
        public IConfiguration Configuration { get; set; }
        string audience;
        protected override async Task OnInitializedAsync()
        {
            audience = Configuration.GetValue<string>("Audience");
        }
    }
}