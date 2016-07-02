using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedSealedClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithInternalNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPrivateNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPublicNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicNestedEnum));
        }
    }
}
