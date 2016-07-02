using CSharpDom.TestTarget.StaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithInternalPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivatePropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicProperty));
        }
    }
}
