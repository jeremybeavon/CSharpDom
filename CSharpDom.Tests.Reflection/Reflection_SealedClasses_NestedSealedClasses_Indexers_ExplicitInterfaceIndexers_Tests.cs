using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedSealedClasses_Indexers_ExplicitInterfaceIndexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceIndexerWith1AccessorAttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceIndexerWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceIndexer));
        }
    }
}
