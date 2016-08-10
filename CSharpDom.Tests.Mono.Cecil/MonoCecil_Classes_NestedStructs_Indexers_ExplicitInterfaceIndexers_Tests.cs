using CSharpDom.TestTarget.Classes.NestedStructs.Indexers.ExplicitInterfaceIndexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_Indexers_ExplicitInterfaceIndexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceIndexerWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceIndexerWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceIndexerWith2ParametersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceIndexerWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithAttributesUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceIndexerUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceIndexer));
        }
    }
}
