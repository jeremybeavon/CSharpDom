using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public async Task TestStructWithNestedAbstractClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithOverridePropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivatePropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithSealedOverridePropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithVirtualPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
