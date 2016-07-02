using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedAbstractClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithEventWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(AbstractClassWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(AbstractClassWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithEventWithGenericDelegateUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithInternalEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewStaticEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewVirtualEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithOverrideEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPrivateEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedInternalEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPublicEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithSealedOverrideEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithStaticEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithVirtualEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
