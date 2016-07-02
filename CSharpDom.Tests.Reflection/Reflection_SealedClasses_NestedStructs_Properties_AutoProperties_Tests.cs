using CSharpDom.TestTarget.SealedClasses.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithInternalAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPrivateAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPublicAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithStaticAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticAutoProperty));
        }
    }
}
