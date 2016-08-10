using CSharpDom.TestTarget.Structs.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_Indexers_ExplicitInterfaceIndexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithExplicitInterfaceIndexerWith1AccessorAttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithExplicitInterfaceIndexerWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithAttributesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithExplicitInterfaceIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceIndexer));
        }
    }
}
