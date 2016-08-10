using CSharpDom.TestTarget.Classes.NestedStructs.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith1AccessorAttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2ParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicIndexer));
        }
    }
}
