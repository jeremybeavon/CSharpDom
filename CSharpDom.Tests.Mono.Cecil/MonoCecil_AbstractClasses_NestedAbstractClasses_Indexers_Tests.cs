using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedAbstractClasses_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithIndexerWithWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithIndexerWithWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithIndexerWith2ParametersWithParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithInternalIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNewIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNewVirtualIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithOverrideIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithPrivateIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithProtectedIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithPublicIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithSealedOverrideIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithVirtualIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithVirtualIndexer));
        }
    }
}
