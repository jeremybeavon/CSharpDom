using CSharpDom.TestTarget.StaticClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedClasses_Indexers_ExplicitInterfaceIndexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitInterfaceIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitInterfaceIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitInterfaceIndexerWith1AttributeUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitInterfaceIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitInterfaceIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithParametersUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitInterfaceIndexerUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitInterfaceIndexer));
        }
    }
}
