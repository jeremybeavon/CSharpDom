using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedAbstractClasses_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExplicitInterfaceEventWith1AccessorAttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExplicitInterfaceEventWith1AttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExplicitInterfaceEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExplicitInterfaceEventWithGenericDelegateUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExplicitInterfaceEventWithGenericInterfaceUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
