using CSharpDom.TestTarget.SealedClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_Indexers_ExplicitInterfaceIndexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithExplicitInterfaceIndexerWith1AccessorAttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExplicitInterfaceIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithExplicitInterfaceIndexerWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExplicitInterfaceIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExplicitInterfaceIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithExplicitInterfaceIndexerUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExplicitInterfaceIndexer));
        }
    }
}
