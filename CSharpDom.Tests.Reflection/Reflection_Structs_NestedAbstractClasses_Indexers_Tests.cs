using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithIndexerWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithIndexerWith2ParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithIndexerWith2ParametersWithParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewVirtualIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithOverrideIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithSealedOverrideIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithVirtualIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualIndexer));
        }
    }
}
