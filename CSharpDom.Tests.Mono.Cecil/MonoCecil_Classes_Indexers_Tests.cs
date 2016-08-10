using CSharpDom.TestTarget.Classes.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithInternalIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNewIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNewIndexer));
        }

        //[TestMethod]
        //public void TestClassWithNewVirtualIndexerUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNewVirtualIndexer));
        //}

        [TestMethod]
        public void TestClassWithOverrideIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithPrivateIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithProtectedIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithPublicIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithSealedOverrideIndexer));
        //}

        [TestMethod]
        public void TestClassWithVirtualIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithVirtualIndexer));
        }
    }
}
