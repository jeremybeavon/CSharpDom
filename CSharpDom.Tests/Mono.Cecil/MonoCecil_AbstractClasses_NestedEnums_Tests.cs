using CSharpDom.TestTarget.AbstractClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithInternalNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicNestedEnum));
        }
    }
}
