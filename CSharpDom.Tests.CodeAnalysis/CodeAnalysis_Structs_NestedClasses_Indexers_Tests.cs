using CSharpDom.TestTarget.Structs.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverrideIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVirtualIndexer));
        }
    }
}
