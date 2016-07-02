using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Indexers_ExplicitInterfaceIndexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExplicitInterfaceIndexerWith1AccessorAttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExplicitInterfaceIndexerWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithModifiersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExplicitInterfaceIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceIndexer));
        }
    }
}
