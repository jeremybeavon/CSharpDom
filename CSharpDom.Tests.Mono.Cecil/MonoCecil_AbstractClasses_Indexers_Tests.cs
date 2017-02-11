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
            TestAbstractClass(typeof(AbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalIndexerUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithNewIndexerUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNewIndexer));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNewVirtualIndexerUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualIndexer));
        //}

        [TestMethod]
        public void TestAbstractClassWithOverrideIndexerUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateIndexerUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedIndexerUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicIndexerUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestAbstractClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideIndexer));
        //}

        [TestMethod]
        public void TestAbstractClassWithVirtualIndexerUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithVirtualIndexer));
        }
    }
}
