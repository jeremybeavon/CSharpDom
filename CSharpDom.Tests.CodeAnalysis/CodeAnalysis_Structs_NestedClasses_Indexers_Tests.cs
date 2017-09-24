using CSharpDom.TestTarget.Structs.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalIndexerUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewIndexerUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewVirtualIndexerUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithOverrideIndexerUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateIndexerUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedIndexerUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalIndexerUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicIndexerUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithSealedOverrideIndexerUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVirtualIndexerUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVirtualIndexer));
        }
    }
}
