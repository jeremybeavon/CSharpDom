using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedStaticClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithInternalPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPrivatePropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPublicPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicProperty));
        }
    }
}
