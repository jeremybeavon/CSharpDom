using CSharpDom.TestTarget.SealedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithInternalIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNewIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithOverrideIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithPublicIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverrideIndexerUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithSealedOverrideIndexer));
        }
    }
}
