using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStaticClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithInternalAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPrivateAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPublicAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}
