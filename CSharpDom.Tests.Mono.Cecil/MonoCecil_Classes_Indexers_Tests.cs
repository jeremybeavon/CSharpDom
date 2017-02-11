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
            TestClass(typeof(ClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestClass(typeof(ClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithInternalIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNewIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNewIndexer));
        }

        //[TestMethod]
        //public void TestClassWithNewVirtualIndexerUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNewVirtualIndexer));
        //}

        [TestMethod]
        public void TestClassWithOverrideIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithPrivateIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithProtectedIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithPublicIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithSealedOverrideIndexer));
        //}

        [TestMethod]
        public void TestClassWithVirtualIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithVirtualIndexer));
        }
    }
}
