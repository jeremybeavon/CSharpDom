using CSharpDom.TestTarget.Classes.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithIndexerWithWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWithWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewVirtualIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithOverrideIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithSealedOverrideIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithVirtualIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVirtualIndexer));
        }
    }
}
