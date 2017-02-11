using CSharpDom.TestTarget.Classes.NestedSealedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2ParametersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithSealedOverrideIndexer));
        }
    }
}
