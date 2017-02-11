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
            TestStaticClass(typeof(StaticClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalIndexerUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewIndexerUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewIndexer));
        }

        //[TestMethod]
        //public void TestStaticClassWithNestedClassWithNewVirtualIndexerUsingMonoCecil()
        //{
        //    TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualIndexer));
        //}

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideIndexerUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateIndexerUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedIndexerUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicIndexerUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestStaticClassWithNestedClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideIndexer));
        //}

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualIndexerUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithVirtualIndexer));
        }
    }
}
