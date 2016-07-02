using CSharpDom.TestTarget.Structs.NestedSealedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithIndexerWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithIndexerWithWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWithWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithIndexerWith2ParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithIndexerWith2ParametersWithParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithOverrideIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivateIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithSealedOverrideIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideIndexer));
        }
    }
}
