using CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedEnumWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithInternalNestedEnumUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPrivateNestedEnumUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedNestedEnumUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedInternalNestedEnumUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPublicNestedEnumUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicNestedEnum));
        }
    }
}
