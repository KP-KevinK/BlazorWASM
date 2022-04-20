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
        string ktest;
        protected override async Task OnInitializedAsync()
        {
            audience = Configuration.GetValue<string>("Audience");
            ktest = Configuration.GetValue<string>("Audience");
        }
    }
}