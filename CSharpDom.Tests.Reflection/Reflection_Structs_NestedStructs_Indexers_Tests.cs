using CSharpDom.TestTarget.Structs.NestedStructs.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithIndexerWith1AccessorAttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithIndexerWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithIndexerWith2ParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicIndexer));
        }
    }
}
