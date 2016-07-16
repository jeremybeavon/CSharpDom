using CSharpDom.TestTarget.Structs.NestedStructs.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedEnumWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicNestedEnum));
        }
    }
}
