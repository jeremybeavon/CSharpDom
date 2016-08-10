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
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithInternalIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithNewIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithOverrideIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestSealedClassWithPublicIndexerUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestSealedClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithSealedOverrideIndexer));
        //}
    }
}
