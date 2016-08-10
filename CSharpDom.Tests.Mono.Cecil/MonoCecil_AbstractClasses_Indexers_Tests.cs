using CSharpDom.TestTarget.AbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalIndexerUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNewIndexerUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewIndexer));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNewVirtualIndexerUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualIndexer));
        //}

        [TestMethod]
        public void TestAbstractClassWithOverrideIndexerUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateIndexerUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedIndexerUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicIndexerUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestAbstractClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideIndexer));
        //}

        [TestMethod]
        public void TestAbstractClassWithVirtualIndexerUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithVirtualIndexer));
        }
    }
}
