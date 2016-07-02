using CSharpDom.TestTarget.Structs.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWithWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWithWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith2ParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith2ParametersWithParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewVirtualIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithOverrideIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithSealedOverrideIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVirtualIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVirtualIndexer));
        }
    }
}
