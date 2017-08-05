using CSharpDom.TestTarget.Structs.NestedStructs.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithIndexerWithWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithIndexerWithWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithIndexerWithWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithIndexerWithWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalIndexerUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateIndexerUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicIndexerUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicIndexer));
        }
    }
}
