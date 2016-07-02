using CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalNestedEnumUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateNestedEnumUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedNestedEnumUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicNestedEnumUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicNestedEnum));
        }
    }
}
