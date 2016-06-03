using CSharpDom.TestTarget.StaticClasses.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(AbstractClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(AbstractClassWithNestedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithEventWithGenericDelegateUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithInternalEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewStaticEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewVirtualEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithOverrideEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPrivateEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedInternalEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPublicEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithSealedOverrideEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithStaticEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithVirtualEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualEvent));
        }
    }
}
