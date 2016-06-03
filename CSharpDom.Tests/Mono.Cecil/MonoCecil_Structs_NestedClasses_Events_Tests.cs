using CSharpDom.TestTarget.Structs.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(AbstractClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(AbstractClassWithNestedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewVirtualEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithOverrideEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithSealedOverrideEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVirtualEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVirtualEvent));
        }
    }
}
