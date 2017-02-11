using CSharpDom.TestTarget.Classes.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNewIndexer));
        }

        //[TestMethod]
        //public void TestClassWithNestedClassWithNewVirtualIndexerUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualIndexer));
        //}

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestClassWithNestedClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideIndexer));
        //}

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithVirtualIndexer));
        }
    }
}
