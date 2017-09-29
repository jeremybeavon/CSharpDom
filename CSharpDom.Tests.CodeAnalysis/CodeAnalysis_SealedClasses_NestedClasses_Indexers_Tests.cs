using CSharpDom.TestTarget.SealedClasses.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedClasses_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVirtualIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverrideIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualIndexer));
        }
    }
}
