using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedClasses_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithExplicitInterfaceEventWith1AccessorAttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithExplicitInterfaceEventWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithExplicitInterfaceEventUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithExplicitInterfaceEventWithGenericDelegateUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithExplicitInterfaceEventWithGenericInterfaceUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
