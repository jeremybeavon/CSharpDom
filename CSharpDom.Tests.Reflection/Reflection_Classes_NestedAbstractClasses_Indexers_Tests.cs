using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedAbstractClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith2ParametersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVirtualIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverrideIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithSealedOverrideIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithVirtualIndexer));
        }
    }
}
