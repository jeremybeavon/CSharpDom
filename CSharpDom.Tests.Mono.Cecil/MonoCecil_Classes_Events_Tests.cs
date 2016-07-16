using CSharpDom.TestTarget.Classes.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithEventWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithInternalEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNewEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithNewVirtualEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestClassWithOverrideEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithPrivateEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestClassWithProtectedEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithPublicEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestClassWithSealedOverrideEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithStaticEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithVirtualEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithVirtualEvent));
        }
    }
}
