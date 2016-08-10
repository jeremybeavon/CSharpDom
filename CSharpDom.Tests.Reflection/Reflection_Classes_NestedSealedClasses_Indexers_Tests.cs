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
            TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2ParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideIndexer));
        }
    }
}
