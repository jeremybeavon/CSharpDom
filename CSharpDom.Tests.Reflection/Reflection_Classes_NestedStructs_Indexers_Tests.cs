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
            TestClass(typeof(ClassWithNestedStructWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2ParametersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithPublicIndexer));
        }
    }
}
