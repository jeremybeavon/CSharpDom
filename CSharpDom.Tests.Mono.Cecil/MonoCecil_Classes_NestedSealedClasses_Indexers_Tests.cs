using CSharpDom.TestTarget.Classes.NestedSealedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedSealedClasses_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicIndexerUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestClassWithNestedSealedClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideIndexer));
        //}
    }
}
