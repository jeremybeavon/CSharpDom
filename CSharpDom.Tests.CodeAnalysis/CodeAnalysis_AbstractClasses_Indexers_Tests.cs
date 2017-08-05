using CSharpDom.TestTarget.AbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWithWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWithWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestAbstractClassWithInternalIndexerUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewIndexerUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewVirtualIndexerUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithOverrideIndexerUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateIndexerUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedIndexerUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalIndexerUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicIndexerUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithSealedOverrideIndexerUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVirtualIndexerUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVirtualIndexer));
        }
    }
}
