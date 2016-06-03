using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStaticClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithInternalPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPrivatePropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPublicPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPublicProperty));
        }
    }
}
