using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStructs_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithInternalPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPrivatePropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPublicPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithStaticPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticProperty));
        }
    }
}
