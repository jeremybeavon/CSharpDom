using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_Indexers_ExplicitInterfaceIndexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitInterfaceIndexerUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexer));
        }
    }
}
