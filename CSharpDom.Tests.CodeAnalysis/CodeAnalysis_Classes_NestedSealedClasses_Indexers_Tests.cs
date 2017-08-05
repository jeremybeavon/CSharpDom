using CSharpDom.TestTarget.Classes.NestedSealedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedSealedClasses_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithIndexerWithWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWithWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithInternalIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithOverrideIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPrivateIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedInternalIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithSealedOverrideIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideIndexer));
        }
    }
}
