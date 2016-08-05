using CSharpDom.TestTarget.AbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestAbstractClassWithInternalIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewVirtualIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithOverrideIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithSealedOverrideIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVirtualIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVirtualIndexer));
        }
    }
}
