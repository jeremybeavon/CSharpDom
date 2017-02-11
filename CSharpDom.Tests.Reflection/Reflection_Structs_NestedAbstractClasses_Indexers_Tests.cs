using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2ParametersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverrideIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithVirtualIndexer));
        }
    }
}
