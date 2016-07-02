using CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedEnumWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivateNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicNestedEnumUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicNestedEnum));
        }
    }
}
