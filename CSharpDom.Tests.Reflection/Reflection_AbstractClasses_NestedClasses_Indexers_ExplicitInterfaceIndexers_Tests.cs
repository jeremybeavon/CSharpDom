using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_Indexers_ExplicitInterfaceIndexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithExplicitInterfaceIndexerWith1AccessorAttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExplicitInterfaceIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithExplicitInterfaceIndexerWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExplicitInterfaceIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExplicitInterfaceIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithExplicitInterfaceIndexerUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExplicitInterfaceIndexer));
        }
    }
}
