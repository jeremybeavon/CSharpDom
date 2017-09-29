using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedAbstractClasses_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewVirtualIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithOverrideIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivateIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithSealedOverrideIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithVirtualIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVirtualIndexer));
        }
    }
}
