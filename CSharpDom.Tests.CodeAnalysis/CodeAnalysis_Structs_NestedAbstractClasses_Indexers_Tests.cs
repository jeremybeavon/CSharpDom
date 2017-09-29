using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedAbstractClasses_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverrideIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualIndexer));
        }
    }
}
