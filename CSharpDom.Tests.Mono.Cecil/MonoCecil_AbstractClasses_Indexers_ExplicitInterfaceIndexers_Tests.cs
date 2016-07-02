using CSharpDom.TestTarget.AbstractClasses.Indexers.ExplicitInterfaceIndexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_Indexers_ExplicitInterfaceIndexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithExplicitInterfaceIndexerWith1AccessorAttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExplicitInterfaceIndexerWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExplicitInterfaceIndexerWith2ParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithModifiersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExplicitInterfaceIndexerUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceIndexer));
        }
    }
}
