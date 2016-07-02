using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithEventWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(AbstractClassWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(AbstractClassWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewVirtualEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithOverrideEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithSealedOverrideEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithVirtualEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
