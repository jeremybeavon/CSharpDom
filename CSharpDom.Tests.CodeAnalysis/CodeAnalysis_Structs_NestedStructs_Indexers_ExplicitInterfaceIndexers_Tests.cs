using CSharpDom.TestTarget.Structs.NestedStructs.Indexers.ExplicitInterfaceIndexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_Indexers_ExplicitInterfaceIndexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithExplicitInterfaceIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExplicitInterfaceIndexerWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExplicitInterfaceIndexerWith2ParametersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExplicitInterfaceIndexerUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceIndexer));
        }
    }
}
