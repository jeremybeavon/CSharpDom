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
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2ParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverrideIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVirtualIndexer));
        }
    }
}
