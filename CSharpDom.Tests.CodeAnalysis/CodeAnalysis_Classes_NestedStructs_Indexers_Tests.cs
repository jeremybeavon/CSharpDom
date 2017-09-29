using CSharpDom.TestTarget.Classes.NestedStructs.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicIndexerUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicIndexer));
        }
    }
}
