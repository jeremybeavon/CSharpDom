using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedSealedClasses_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExplicitInterfaceEventWith1AccessorAttributeUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExplicitInterfaceEventWith1AttributeUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExplicitInterfaceEventUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExplicitInterfaceEventWithGenericDelegateUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExplicitInterfaceEventWithGenericInterfaceUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
