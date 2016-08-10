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
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2ParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicIndexer));
        }
    }
}
