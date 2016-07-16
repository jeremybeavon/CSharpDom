using CSharpDom.TestTarget.Structs.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithInternalNestedEnumUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithPrivateNestedEnumUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithPublicNestedEnumUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithPublicNestedEnum));
        }
    }
}
