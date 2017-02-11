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
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithNewIndexer));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedAbstractClassWithNewVirtualIndexerUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVirtualIndexer));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithOverrideIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivateIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedAbstractClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithSealedOverrideIndexer));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithVirtualIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithVirtualIndexer));
        }
    }
}
