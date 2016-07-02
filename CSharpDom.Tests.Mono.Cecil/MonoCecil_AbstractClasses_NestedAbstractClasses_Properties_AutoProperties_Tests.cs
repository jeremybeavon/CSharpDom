using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithInternalAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNewAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithPublicAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithStaticAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
