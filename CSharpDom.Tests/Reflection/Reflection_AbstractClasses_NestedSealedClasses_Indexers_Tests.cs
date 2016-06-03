using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedSealedClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithIndexerWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithIndexerWithWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithIndexerWithWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithIndexerWith2ParametersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithIndexerWith2ParametersWithParametersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithInternalIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNewIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithOverrideIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPrivateIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedInternalIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPublicIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithSealedOverrideIndexerUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithSealedOverrideIndexer));
        }
    }
}
