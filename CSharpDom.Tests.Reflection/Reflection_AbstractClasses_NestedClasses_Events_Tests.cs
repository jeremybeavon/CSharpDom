using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventWithGenericDelegateUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithInternalEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewStaticEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewVirtualEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithOverrideEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPrivateEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedInternalEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPublicEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithSealedOverrideEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithStaticEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithVirtualEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualEvent));
        }
    }
}
