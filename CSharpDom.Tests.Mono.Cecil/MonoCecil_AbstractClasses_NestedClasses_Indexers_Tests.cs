using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedClasses_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalIndexerUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewIndexerUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewIndexer));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNestedClassWithNewVirtualIndexerUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualIndexer));
        //}

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverrideIndexerUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateIndexerUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedIndexerUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicIndexerUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNestedClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideIndexer));
        //}

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualIndexerUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualIndexer));
        }
    }
}
