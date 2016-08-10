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
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2ParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverrideIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVirtualIndexer));
        }
    }
}
