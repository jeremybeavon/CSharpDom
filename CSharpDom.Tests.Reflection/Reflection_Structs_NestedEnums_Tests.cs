using CSharpDom.TestTarget.Structs.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedEnumWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithInternalNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithPrivateNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithPublicNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithPublicNestedEnum));
        }
    }
}
