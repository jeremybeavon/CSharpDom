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
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith2ParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVirtualIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverrideIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithSealedOverrideIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualIndexer));
        }
    }
}
