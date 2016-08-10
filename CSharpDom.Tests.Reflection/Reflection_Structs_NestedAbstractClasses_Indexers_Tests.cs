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
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2ParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverrideIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualIndexer));
        }
    }
}
