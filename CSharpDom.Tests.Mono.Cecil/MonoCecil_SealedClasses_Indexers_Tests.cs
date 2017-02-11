using CSharpDom.TestTarget.SealedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithInternalIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNewIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithOverrideIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithPublicIndexerUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestSealedClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithSealedOverrideIndexer));
        //}
    }
}
