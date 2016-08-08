using CSharpDom.TestTarget.Classes.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith2ParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithInternalIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNewIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNewVirtualIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestClassWithOverrideIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestClassWithPrivateIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestClassWithProtectedIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithPublicIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestClassWithSealedOverrideIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestClassWithVirtualIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithVirtualIndexer));
        }
    }
}
