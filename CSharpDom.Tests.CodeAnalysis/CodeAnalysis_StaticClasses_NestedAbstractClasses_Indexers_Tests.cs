using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedAbstractClasses_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithInternalIndexerUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewIndexerUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewVirtualIndexerUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithOverrideIndexerUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPrivateIndexerUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedIndexerUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedInternalIndexerUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPublicIndexerUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithSealedOverrideIndexerUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithVirtualIndexerUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithVirtualIndexer));
        }
    }
}
