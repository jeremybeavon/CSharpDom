using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedSealedClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithIndexerWith1AttributeUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithIndexerWith2ParametersUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithInternalIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithOverrideIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPrivateIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedInternalIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPublicIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithSealedOverrideIndexerUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithSealedOverrideIndexer));
        }
    }
}
