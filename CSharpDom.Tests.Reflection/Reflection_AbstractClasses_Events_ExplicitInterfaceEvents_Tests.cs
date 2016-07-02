using CSharpDom.TestTarget.AbstractClasses.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithExplicitInterfaceEventWith1AccessorAttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExplicitInterfaceEventWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExplicitInterfaceEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExplicitInterfaceEventWithGenericDelegateUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExplicitInterfaceEventWithGenericInterfaceUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
