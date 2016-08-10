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
            TestClassAsync(typeof(ClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithIndexerWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2ParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithInternalIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithNewIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewIndexer));
        }

        [TestMethod]
        public void TestClassWithNewVirtualIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public void TestClassWithOverrideIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithPrivateIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPrivateIndexer));
        }

        [TestMethod]
        public void TestClassWithProtectedIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedIndexer));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public void TestClassWithPublicIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPublicIndexer));
        }

        [TestMethod]
        public void TestClassWithSealedOverrideIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public void TestClassWithVirtualIndexerUsingReflection()
        {
            TestClassAsync(typeof(ClassWithVirtualIndexer));
        }
    }
}
