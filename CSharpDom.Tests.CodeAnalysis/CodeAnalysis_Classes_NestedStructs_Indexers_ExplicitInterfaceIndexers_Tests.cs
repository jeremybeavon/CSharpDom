using CSharpDom.TestTarget.Classes.NestedStructs.Indexers.ExplicitInterfaceIndexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_Indexers_ExplicitInterfaceIndexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceIndexerWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceIndexerWith2ParametersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceIndexer));
        }
    }
}
