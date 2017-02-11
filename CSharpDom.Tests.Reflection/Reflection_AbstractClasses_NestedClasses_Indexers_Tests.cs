using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith1AttributeUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith2ParametersUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVirtualIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverrideIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithSealedOverrideIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithVirtualIndexer));
        }
    }
}
