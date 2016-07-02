using CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedSealedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithOverridePropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivatePropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithSealedOverridePropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticProperty));
        }
    }
}
