using CSharpDom.TestTarget.StaticClasses.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventWith1AttributeUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(AbstractClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(AbstractClassWithNestedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithInternalEventUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewEventUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewStaticEventUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewVirtualEventUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithOverrideEventUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPrivateEventUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedEventUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedInternalEventUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPublicEventUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithSealedOverrideEventUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithStaticEventUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithVirtualEventUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualEvent));
        }
    }
}
