using CSharpDom.TestTarget.AbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithEventWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventWithGenericDelegateUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithInternalEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewVirtualEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithOverrideEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithSealedOverrideEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVirtualEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVirtualEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }
    }
}
