using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStaticClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithInternalPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPrivatePropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPublicPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicProperty));
        }
    }
}
