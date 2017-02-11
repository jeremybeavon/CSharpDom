using CSharpDom.TestTarget.Structs.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithNewIndexer));
        }

        //[TestMethod]
        //public void TestStructWithNestedClassWithNewVirtualIndexerUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedClassWithNewVirtualIndexer));
        //}

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestStructWithNestedClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideIndexer));
        //}

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithVirtualIndexer));
        }
    }
}
