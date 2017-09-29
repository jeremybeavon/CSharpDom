using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedSealedClasses_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithIndexerWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithInternalIndexerUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewIndexerUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithOverrideIndexerUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivateIndexerUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedIndexerUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalIndexerUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicIndexerUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithSealedOverrideIndexerUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithSealedOverrideIndexer));
        }
    }
}
