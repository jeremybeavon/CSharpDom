using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedSealedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithInternalPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNewPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNewStaticPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithOverridePropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPrivatePropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPublicPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithSealedOverridePropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithStaticPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
