using CSharpDom.TestTarget.AbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithInternalPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public async Task TestAbstractClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    await TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public async Task TestAbstractClassWithOverridePropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivatePropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithSealedOverridePropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVirtualPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVirtualProperty));
        }
    }
}
