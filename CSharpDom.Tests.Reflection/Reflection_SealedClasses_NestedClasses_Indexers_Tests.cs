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
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2ParametersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVirtualIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverrideIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualIndexer));
        }
    }
}
