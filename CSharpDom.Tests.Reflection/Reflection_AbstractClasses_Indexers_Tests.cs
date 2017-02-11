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
            TestAbstractClass(typeof(AbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith1AttributeUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2ParametersUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNewIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithOverrideIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverrideIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithVirtualIndexer));
        }
    }
}
