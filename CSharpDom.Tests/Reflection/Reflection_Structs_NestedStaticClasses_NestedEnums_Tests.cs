using CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStaticClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedEnumWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithInternalNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPrivateNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithProtectedNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithProtectedInternalNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicNestedEnum));
        }
    }
}
