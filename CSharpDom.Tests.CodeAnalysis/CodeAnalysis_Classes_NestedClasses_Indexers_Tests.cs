using CSharpDom.TestTarget.Classes.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverrideIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVirtualIndexer));
        }
    }
}
