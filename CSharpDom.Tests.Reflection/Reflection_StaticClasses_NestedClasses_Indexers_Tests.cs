using CSharpDom.TestTarget.StaticClasses.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith1AttributeUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2ParametersUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalIndexerUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewIndexerUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVirtualIndexerUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideIndexerUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateIndexerUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedIndexerUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalIndexerUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicIndexerUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithSealedOverrideIndexerUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualIndexerUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualIndexer));
        }
    }
}
