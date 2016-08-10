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
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicIndexer));
        }
    }
}
