using MyCompany.MyProject.MongoDB;
using MyCompany.MyProject.Samples;
using Xunit;

namespace MyCompany.MyProject.MongoDb.Applications;

[Collection(MyProjectTestConsts.CollectionDefinitionName)]
public class MongoDBSampleAppServiceTests : SampleAppServiceTests<MyProjectMongoDbTestModule>
{

}
