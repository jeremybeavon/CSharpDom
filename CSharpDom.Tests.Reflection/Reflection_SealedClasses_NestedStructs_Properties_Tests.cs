using CSharpDom.TestTarget.SealedClasses.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithInternalPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPrivatePropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPublicPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithStaticPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticProperty));
        }
    }
}
