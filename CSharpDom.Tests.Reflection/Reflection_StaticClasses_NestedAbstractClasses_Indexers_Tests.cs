using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedAbstractClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithIndexerWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithIndexerWithWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWithWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithIndexerWith2ParametersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithIndexerWith2ParametersWithParametersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithInternalIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewVirtualIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithOverrideIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPrivateIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedInternalIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPublicIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithSealedOverrideIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithVirtualIndexerUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithVirtualIndexer));
        }
    }
}
