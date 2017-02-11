using CSharpDom.TestTarget.Structs.NestedStructs.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithPublicIndexer));
        }
    }
}
