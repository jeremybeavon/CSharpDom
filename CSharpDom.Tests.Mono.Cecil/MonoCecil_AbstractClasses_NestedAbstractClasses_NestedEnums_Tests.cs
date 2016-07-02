using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedAbstractClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithInternalNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithPrivateNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithProtectedNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithPublicNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPublicNestedEnum));
        }
    }
}
