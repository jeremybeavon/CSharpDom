using CSharpDom.TestTarget.SealedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithIndexerWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithIndexerWithWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIndexerWithWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithIndexerWith2ParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithIndexerWith2ParametersWithParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithOverrideIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestSealedClassWithSealedOverrideIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithSealedOverrideIndexer));
        }
    }
}
