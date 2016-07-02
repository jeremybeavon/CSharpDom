using CSharpDom.TestTarget.Structs.NestedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalNestedEnumUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateNestedEnumUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedNestedEnumUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicNestedEnumUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicNestedEnum));
        }
    }
}
