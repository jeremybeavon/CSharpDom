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
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewIndexer));
        }

        //[TestMethod]
        //public void TestClassWithNestedClassWithNewVirtualIndexerUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualIndexer));
        //}

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestClassWithNestedClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideIndexer));
        //}

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVirtualIndexer));
        }
    }
}
