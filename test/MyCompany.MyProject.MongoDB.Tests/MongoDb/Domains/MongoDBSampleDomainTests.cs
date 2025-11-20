using MyCompany.MyProject.Samples;
using Xunit;

namespace MyCompany.MyProject.MongoDB.Domains;

[Collection(MyProjectTestConsts.CollectionDefinitionName)]
public class MongoDBSampleDomainTests : SampleDomainTests<MyProjectMongoDbTestModule>
{

}
