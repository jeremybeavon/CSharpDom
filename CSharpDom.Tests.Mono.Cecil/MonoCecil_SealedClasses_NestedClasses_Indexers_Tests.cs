using CSharpDom.TestTarget.SealedClasses.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedClasses_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewIndexer));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedClassWithNewVirtualIndexerUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualIndexer));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideIndexer));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualIndexer));
        }
    }
}
