using CSharpDom.TestTarget.Structs.NestedStructs.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicIndexer));
        }
    }
}
