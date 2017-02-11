using CSharpDom.TestTarget.SealedClasses.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith1AttributeUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2ParametersUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalIndexerUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewIndexerUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVirtualIndexerUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideIndexerUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateIndexerUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedIndexerUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalIndexerUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicIndexerUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverrideIndexerUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualIndexerUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithVirtualIndexer));
        }
    }
}
