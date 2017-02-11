using CSharpDom.TestTarget.Classes.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithIndexerWith1AccessorAttributeUsingReflection()
        {
            TestClass(typeof(ClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithIndexerWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2ParametersUsingReflection()
        {
            TestClass(typeof(ClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestClass(typeof(ClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestClass(typeof(ClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithInternalIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNewIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNewIndexer));
        }

        [TestMethod]
        public void TestClassWithNewVirtualIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestClassWithOverrideIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithPrivateIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithProtectedIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithPublicIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestClassWithSealedOverrideIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithVirtualIndexerUsingReflection()
        {
            TestClass(typeof(ClassWithVirtualIndexer));
        }
    }
}
