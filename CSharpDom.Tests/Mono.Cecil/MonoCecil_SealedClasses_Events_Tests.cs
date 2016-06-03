using CSharpDom.TestTarget.SealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithEventWith1AttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithOverrideEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithSealedOverrideEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticEvent));
        }
    }
}
