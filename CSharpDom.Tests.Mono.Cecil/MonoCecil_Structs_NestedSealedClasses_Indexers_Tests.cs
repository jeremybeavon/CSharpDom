using CSharpDom.TestTarget.Structs.NestedSealedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedSealedClasses_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestStructWithNestedSealedClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideIndexer));
        //}
    }
}
