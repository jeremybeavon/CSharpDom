using CSharpDom.TestTarget.Structs.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVirtualAutoProperty));
        }
    }
}
