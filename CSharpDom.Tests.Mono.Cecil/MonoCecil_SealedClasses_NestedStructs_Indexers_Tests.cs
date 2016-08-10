using CSharpDom.TestTarget.SealedClasses.NestedStructs.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStructs_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicIndexer));
        }
    }
}
