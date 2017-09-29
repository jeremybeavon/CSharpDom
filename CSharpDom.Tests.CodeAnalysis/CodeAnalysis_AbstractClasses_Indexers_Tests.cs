using CSharpDom.TestTarget.AbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalIndexerUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNewIndexerUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualIndexerUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithOverrideIndexerUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateIndexerUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedIndexerUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalIndexerUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicIndexerUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverrideIndexerUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualIndexerUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithVirtualIndexer));
        }
    }
}
