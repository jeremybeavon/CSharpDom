using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithIndexerWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithIndexerWithWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWithWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithIndexerWith2ParametersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithIndexerWith2ParametersWithParametersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithInternalIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewVirtualIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithOverrideIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPrivateIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedInternalIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPublicIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithSealedOverrideIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithVirtualIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualIndexer));
        }
    }
}
