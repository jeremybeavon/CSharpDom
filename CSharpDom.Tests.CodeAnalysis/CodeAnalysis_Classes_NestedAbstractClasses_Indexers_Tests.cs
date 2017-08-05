using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedAbstractClasses_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithIndexerWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithIndexerWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithIndexerWithWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWithWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithIndexerWith2ParametersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributesUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewVirtualIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithOverrideIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivateIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithSealedOverrideIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithVirtualIndexerUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualIndexer));
        }
    }
}
