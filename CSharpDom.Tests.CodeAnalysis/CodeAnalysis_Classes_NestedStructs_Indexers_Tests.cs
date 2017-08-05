using CSharpDom.TestTarget.Classes.NestedStructs.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithIndexerWithWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIndexerWithWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithIndexerWithWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIndexerWithWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicIndexer));
        }
    }
}
