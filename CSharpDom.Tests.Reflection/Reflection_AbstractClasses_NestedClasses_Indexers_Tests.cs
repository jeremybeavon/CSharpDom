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
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith2ParametersUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVirtualIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverrideIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithSealedOverrideIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualIndexer));
        }
    }
}
