using CSharpDom.TestTarget.StaticClasses.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedClasses_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalIndexerUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewIndexerUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewIndexer));
        }

        //[TestMethod]
        //public void TestStaticClassWithNestedClassWithNewVirtualIndexerUsingMonoCecil()
        //{
        //    TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualIndexer));
        //}

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideIndexerUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateIndexerUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedIndexerUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicIndexerUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestStaticClassWithNestedClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideIndexer));
        //}

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualIndexerUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualIndexer));
        }
    }
}
