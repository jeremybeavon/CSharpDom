using CSharpDom.TestTarget.SealedClasses.NestedStructs.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithIndexerWith1AccessorAttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithIndexerWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithIndexerWith2ParametersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicIndexer));
        }
    }
}
