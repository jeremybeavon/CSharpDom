using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedAbstractClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith1AttributeUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith2ParametersUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithInternalIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithNewIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewVirtualIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithOverrideIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPrivateIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedInternalIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPublicIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithSealedOverrideIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithVirtualIndexerUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithVirtualIndexer));
        }
    }
}
