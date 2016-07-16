using CSharpDom.TestTarget.AbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith2ParametersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith2ParametersWithParametersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestAbstractClassWithInternalIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewVirtualIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithOverrideIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithSealedOverrideIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVirtualIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVirtualIndexer));
        }
    }
}
