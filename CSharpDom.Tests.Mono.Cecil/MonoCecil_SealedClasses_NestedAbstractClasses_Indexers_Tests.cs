using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedAbstractClasses_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewIndexer));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedAbstractClassWithNewVirtualIndexerUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVirtualIndexer));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithOverrideIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivateIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedAbstractClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithSealedOverrideIndexer));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithVirtualIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVirtualIndexer));
        }
    }
}
