using CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedEnumWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicNestedEnum));
        }
    }
}
