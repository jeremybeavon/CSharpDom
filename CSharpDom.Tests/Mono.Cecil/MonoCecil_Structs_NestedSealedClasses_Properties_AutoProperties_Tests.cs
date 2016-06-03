using CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
