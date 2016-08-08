using CSharpDom.TestTarget.Classes.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithInternalIndexerUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNewIndexerUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNewVirtualIndexerUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestClassWithOverrideIndexerUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestClassWithPrivateIndexerUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestClassWithProtectedIndexerUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithPublicIndexerUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestClassWithSealedOverrideIndexerUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestClassWithVirtualIndexerUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithVirtualIndexer));
        }
    }
}
