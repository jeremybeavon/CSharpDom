using CSharpDom.TestTarget.StaticClasses.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithIndexerWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithIndexerWithWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWithWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithIndexerWith2ParametersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithIndexerWith2ParametersWithParametersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithInternalIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewVirtualIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithOverrideIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPrivateIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedInternalIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPublicIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithSealedOverrideIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithVirtualIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualIndexer));
        }
    }
}
