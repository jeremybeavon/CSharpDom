using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedSealedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithInternalPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewStaticPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithOverridePropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPrivatePropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPublicPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithSealedOverridePropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithStaticPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
