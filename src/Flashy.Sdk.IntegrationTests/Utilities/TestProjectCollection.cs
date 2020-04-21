// See the LICENSE.TXT file in the project root for full license information.

using Xunit;

namespace Flashy.Sdk.IntegrationTests
{
    [CollectionDefinition(Name)]
    public class TestProjectCollection : ICollectionFixture<TestProjectFixture>
    {
        public const string Name = nameof(TestProjectCollection);
    }
}
