using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithInternalAutoPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewAutoPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPublicAutoPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithStaticAutoPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
