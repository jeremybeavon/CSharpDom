using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStaticClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithInternalNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPrivateNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithProtectedNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPublicNestedEnumUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicNestedEnum));
        }
    }
}
