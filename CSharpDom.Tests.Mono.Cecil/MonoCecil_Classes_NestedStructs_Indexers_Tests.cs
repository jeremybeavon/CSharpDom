using CSharpDom.TestTarget.Classes.NestedStructs.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithPublicIndexer));
        }
    }
}
