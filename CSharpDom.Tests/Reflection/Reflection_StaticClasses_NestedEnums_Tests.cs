using CSharpDom.TestTarget.StaticClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedEnumWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithInternalNestedEnumUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivateNestedEnumUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithProtectedNestedEnumUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithProtectedInternalNestedEnumUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicNestedEnumUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicNestedEnum));
        }
    }
}
