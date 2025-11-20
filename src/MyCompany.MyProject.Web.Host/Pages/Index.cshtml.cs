using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace MyCompany.MyProject.Web.Pages;

public class IndexModel : MyProjectPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
