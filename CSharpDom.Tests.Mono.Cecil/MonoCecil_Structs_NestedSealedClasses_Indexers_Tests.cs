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
            TestStruct(typeof(StructWithNestedSealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestStructWithNestedSealedClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideIndexer));
        //}
    }
}
