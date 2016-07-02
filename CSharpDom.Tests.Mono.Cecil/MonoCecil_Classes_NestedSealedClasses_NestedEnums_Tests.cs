using CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedSealedClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithInternalNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPrivateNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicNestedEnum));
        }
    }
}
