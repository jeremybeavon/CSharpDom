using CSharpDom.TestTarget.Classes.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2ParametersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverrideIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithVirtualIndexer));
        }
    }
}
