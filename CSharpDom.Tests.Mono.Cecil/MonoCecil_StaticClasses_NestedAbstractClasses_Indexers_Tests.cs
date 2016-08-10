using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedAbstractClasses_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithInternalIndexerUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewIndexerUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewIndexer));
        }

        //[TestMethod]
        //public void TestStaticClassWithNestedAbstractClassWithNewVirtualIndexerUsingMonoCecil()
        //{
        //    TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewVirtualIndexer));
        //}

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithOverrideIndexerUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPrivateIndexerUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedIndexerUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPublicIndexerUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestStaticClassWithNestedAbstractClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithSealedOverrideIndexer));
        //}

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithVirtualIndexerUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithVirtualIndexer));
        }
    }
}
