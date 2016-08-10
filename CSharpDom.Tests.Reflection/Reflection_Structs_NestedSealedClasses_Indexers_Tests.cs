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
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2ParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideIndexer));
        }
    }
}
