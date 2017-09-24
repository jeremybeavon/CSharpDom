using CSharpDom.TestTarget.SealedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithIndexerWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithIndexerWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalIndexerUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewIndexerUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithOverrideIndexerUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateIndexerUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedIndexerUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalIndexerUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicIndexerUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithSealedOverrideIndexerUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithSealedOverrideIndexer));
        }
    }
}
