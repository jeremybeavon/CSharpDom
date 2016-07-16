using CSharpDom.TestTarget.SealedClasses.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithIndexerWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithIndexerWith2ParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithIndexerWith2ParametersWithParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithInternalIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewVirtualIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithOverrideIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPrivateIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedInternalIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPublicIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithSealedOverrideIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithVirtualIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualIndexer));
        }
    }
}
