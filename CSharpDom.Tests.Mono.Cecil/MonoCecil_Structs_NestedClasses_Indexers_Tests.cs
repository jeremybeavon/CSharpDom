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
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewIndexer));
        }

        //[TestMethod]
        //public void TestStructWithNestedClassWithNewVirtualIndexerUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedClassWithNewVirtualIndexer));
        //}

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestStructWithNestedClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideIndexer));
        //}

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVirtualIndexer));
        }
    }
}
