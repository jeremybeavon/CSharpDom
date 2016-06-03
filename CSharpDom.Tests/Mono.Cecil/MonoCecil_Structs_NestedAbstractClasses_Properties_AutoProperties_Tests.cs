using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
