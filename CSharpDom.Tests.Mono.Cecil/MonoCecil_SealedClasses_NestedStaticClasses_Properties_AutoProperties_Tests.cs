using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStaticClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithInternalAutoPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPublicAutoPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}
