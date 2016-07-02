using CSharpDom.TestTarget.AbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithInternalAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVirtualAutoProperty));
        }
    }
}
