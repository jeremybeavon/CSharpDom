using CSharpDom.TestTarget.Structs.NestedSealedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2ParametersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithSealedOverrideIndexer));
        }
    }
}
