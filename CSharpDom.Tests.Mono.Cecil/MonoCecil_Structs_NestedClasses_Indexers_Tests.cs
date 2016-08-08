using CSharpDom.TestTarget.Structs.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalIndexerUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewIndexerUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewVirtualIndexerUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithOverrideIndexerUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateIndexerUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedIndexerUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicIndexerUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithSealedOverrideIndexerUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVirtualIndexerUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVirtualIndexer));
        }
    }
}
