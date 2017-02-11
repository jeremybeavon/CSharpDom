using CSharpDom.TestTarget.Structs.NestedStructs.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith1AccessorAttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2ParametersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithPublicIndexer));
        }
    }
}
