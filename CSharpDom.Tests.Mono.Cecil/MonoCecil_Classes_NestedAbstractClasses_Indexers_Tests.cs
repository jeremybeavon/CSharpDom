using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith2ParametersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewIndexer));
        }

        //[TestMethod]
        //public void TestClassWithNestedAbstractClassWithNewVirtualIndexerUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualIndexer));
        //}

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverrideIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicIndexer));
        }

        //[TestMethod]
        //public void TestClassWithNestedAbstractClassWithSealedOverrideIndexerUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideIndexer));
        //}

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualIndexer));
        }
    }
}
