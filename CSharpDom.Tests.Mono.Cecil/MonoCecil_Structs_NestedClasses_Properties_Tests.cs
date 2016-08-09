using CSharpDom.TestTarget.Structs.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public async Task TestStructWithNestedClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    await TestStructAsync(typeof(StructWithNestedClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public async Task TestStructWithNestedClassWithOverridePropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivatePropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithSealedOverridePropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVirtualPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVirtualProperty));
        }
    }
}
