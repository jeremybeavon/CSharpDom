using CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithInternalPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewStaticPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public async Task TestSealedClassWithNestedClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithOverridePropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPrivatePropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPublicPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithSealedOverridePropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithStaticPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithVirtualPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualProperty));
        }
    }
}
