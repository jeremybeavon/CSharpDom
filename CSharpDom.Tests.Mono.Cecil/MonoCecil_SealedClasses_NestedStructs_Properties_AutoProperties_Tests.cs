using CSharpDom.TestTarget.SealedClasses.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithInternalAutoPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPrivateAutoPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPublicAutoPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithStaticAutoPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticAutoProperty));
        }
    }
}
