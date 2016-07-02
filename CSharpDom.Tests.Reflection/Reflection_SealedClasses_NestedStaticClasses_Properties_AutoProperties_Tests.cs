using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStaticClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithInternalAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPrivateAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPublicAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}
