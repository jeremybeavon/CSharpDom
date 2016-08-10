using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStructs_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStructWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithInternalIndexerUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPrivateIndexerUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPublicIndexerUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicIndexer));
        }
    }
}
