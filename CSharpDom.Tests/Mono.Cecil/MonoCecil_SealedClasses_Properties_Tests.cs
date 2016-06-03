using CSharpDom.TestTarget.SealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithInternalPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithOverridePropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivatePropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithSealedOverridePropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticProperty));
        }
    }
}
