using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewIndexer));
        }

        //[TestMethod]
        //public void TestStructWithNestedAbstractClassWithNewVirtualIndexerUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualIndexer));
        //}

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestStructWithNestedAbstractClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideIndexer));
        //}

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithVirtualIndexer));
        }
    }
}
