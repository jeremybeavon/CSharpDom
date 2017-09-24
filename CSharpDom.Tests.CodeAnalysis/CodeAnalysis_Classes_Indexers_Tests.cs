using CSharpDom.TestTarget.Classes.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithInternalIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNewIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNewVirtualIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestClassWithOverrideIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestClassWithPrivateIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestClassWithProtectedIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithPublicIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestClassWithSealedOverrideIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestClassWithVirtualIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithVirtualIndexer));
        }
    }
}
