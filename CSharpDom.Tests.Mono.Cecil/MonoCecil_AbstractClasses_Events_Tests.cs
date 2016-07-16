using CSharpDom.TestTarget.AbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithEventWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithInternalEventUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewEventUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticEventUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewVirtualEventUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithOverrideEventUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateEventUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedEventUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalEventUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicEventUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithSealedOverrideEventUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticEventUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVirtualEventUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVirtualEvent));
        }
    }
}
