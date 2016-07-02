using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithInternalAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPrivateAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPublicAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithStaticAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticAutoProperty));
        }
    }
}
