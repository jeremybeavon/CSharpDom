using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedSealedClasses_Indexers_ExplicitInterfaceIndexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith1AttributeUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithParametersUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExplicitInterfaceIndexerUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceIndexer));
        }
    }
}
