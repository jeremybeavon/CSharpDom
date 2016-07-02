using CSharpDom.TestTarget.Structs.NestedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedEnumWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicNestedEnum));
        }
    }
}
