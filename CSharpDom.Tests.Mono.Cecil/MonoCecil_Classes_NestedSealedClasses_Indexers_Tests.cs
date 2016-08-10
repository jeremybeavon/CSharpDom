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
            TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestClassWithNestedSealedClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideIndexer));
        //}
    }
}
