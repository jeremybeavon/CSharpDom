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
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicIndexer));
        }
    }
}
