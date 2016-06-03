using CSharpDom.TestTarget.Classes.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedEnumWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithPrivateNestedEnumUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithProtectedNestedEnumUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalNestedEnumUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithInternalNestedEnumUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithPublicNestedEnumUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPublicNestedEnum));
        }
    }
}
