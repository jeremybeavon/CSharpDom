using CSharpDom.TestTarget.Structs.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2ParametersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverrideIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithVirtualIndexer));
        }
    }
}
