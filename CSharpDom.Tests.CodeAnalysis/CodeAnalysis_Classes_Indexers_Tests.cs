using CSharpDom.TestTarget.Classes.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithInternalIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNewIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewIndexer));
        }

        [TestMethod]
        public void TestClassWithNewVirtualIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestClassWithOverrideIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithPrivateIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithProtectedIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithPublicIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestClassWithSealedOverrideIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithVirtualIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithVirtualIndexer));
        }
    }
}
