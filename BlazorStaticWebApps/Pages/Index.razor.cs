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
        string david;
        protected override async Task OnInitializedAsync()
        {
            audience = Configuration.GetValue<string>("Values:Audience");
            ktest = Configuration.GetValue<string>("Values:test");
            david = Configuration.GetValue<string>("Values:david");
        }
    }
}