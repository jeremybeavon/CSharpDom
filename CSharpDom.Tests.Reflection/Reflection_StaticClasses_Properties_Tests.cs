using CSharpDom.TestTarget.StaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithInternalPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivatePropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicProperty));
        }
    }
}
