using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace MyCompany.MyProject.MongoDB;

[DependsOn(
    typeof(MyProjectApplicationTestModule),
    typeof(MyProjectMongoDbModule)
)]
public class MyProjectMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = MyProjectMongoDbFixture.GetRandomConnectionString();
        });
    }
}
