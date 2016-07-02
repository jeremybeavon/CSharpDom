using CSharpDom.TestTarget.SealedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedEnumWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalNestedEnumUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateNestedEnumUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedNestedEnumUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalNestedEnumUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicNestedEnumUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicNestedEnum));
        }
    }
}
