using CSharpDom.TestTarget.Classes.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithEventWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithEventWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithEventWithGenericDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithInternalEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNewEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithNewVirtualEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestClassWithOverrideEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithPrivateEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestClassWithProtectedEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithPublicEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestClassWithSealedOverrideEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithStaticEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithVirtualEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithVirtualEvent));
        }
    }
}
