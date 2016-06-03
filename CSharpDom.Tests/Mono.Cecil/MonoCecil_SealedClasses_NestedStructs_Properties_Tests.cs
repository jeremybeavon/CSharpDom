using CSharpDom.TestTarget.SealedClasses.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStructs_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithInternalPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPrivatePropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPublicPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithStaticPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticProperty));
        }
    }
}
