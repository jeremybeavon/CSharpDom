using CSharpDom.TestTarget.AbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2ParametersUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNewIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithOverrideIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverrideIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithVirtualIndexer));
        }
    }
}
