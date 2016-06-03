using CSharpDom.TestTarget.Structs.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedSealedClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithEventWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(AbstractClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(AbstractClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithOverrideEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivateEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithSealedOverrideEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticEvent));
        }
    }
}
