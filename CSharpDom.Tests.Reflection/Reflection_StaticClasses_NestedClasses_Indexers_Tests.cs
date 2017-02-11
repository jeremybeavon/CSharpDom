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
            TestStaticClass(typeof(StaticClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith1AttributeUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2ParametersUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVirtualIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithSealedOverrideIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithVirtualIndexer));
        }
    }
}
