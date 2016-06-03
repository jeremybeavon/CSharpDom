using CSharpDom.TestTarget.Classes.NestedStructs.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedEnumWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedEnumWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalNestedEnumUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateNestedEnumUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicNestedEnumUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicNestedEnum));
        }
    }
}
