using MyCompany.MyProject.Localization;
using Volo.Abp.AspNetCore.Components;

namespace MyCompany.MyProject.Blazor.Server.Tiered;

public abstract class MyProjectComponentBase : AbpComponentBase
{
    protected MyProjectComponentBase()
    {
        LocalizationResource = typeof(MyProjectResource);
    }
}
