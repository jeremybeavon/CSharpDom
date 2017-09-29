using CSharpDom.TestTarget.Structs.NestedSealedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideIndexer));
        }
    }
}
