using CSharpDom.TestTarget.Classes.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithIndexerWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithIndexerWith2ParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithIndexerWith2ParametersWithParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewVirtualIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithOverrideIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithSealedOverrideIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithVirtualIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVirtualIndexer));
        }
    }
}
