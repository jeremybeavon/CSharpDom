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
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewIndexer));
        }

        //[TestMethod]
        //public void TestStructWithNestedAbstractClassWithNewVirtualIndexerUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualIndexer));
        //}

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestStructWithNestedAbstractClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideIndexer));
        //}

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualIndexer));
        }
    }
}
