using CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedEnumWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithInternalNestedEnumUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPrivateNestedEnumUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedNestedEnumUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedInternalNestedEnumUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPublicNestedEnumUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicNestedEnum));
        }
    }
}
