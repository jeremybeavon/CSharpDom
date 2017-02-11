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
            TestSealedClass(typeof(SealedClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewIndexer));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedClassWithNewVirtualIndexerUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualIndexer));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideIndexer));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithVirtualIndexer));
        }
    }
}
