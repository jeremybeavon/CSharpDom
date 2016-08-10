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
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2ParametersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithInternalIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNewIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithOverrideIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithPublicIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverrideIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithSealedOverrideIndexer));
        }
    }
}
