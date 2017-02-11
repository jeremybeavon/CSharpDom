using CSharpDom.TestTarget.SealedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith1AttributeUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2ParametersUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithInternalIndexerUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNewIndexerUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithOverrideIndexerUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateIndexerUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedIndexerUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalIndexerUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithPublicIndexerUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverrideIndexerUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithSealedOverrideIndexer));
        }
    }
}
