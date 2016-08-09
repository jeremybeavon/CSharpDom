using CSharpDom.TestTarget.SealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithEventWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventWithGenericDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithOverrideEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithSealedOverrideEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticEvent));
        }
    }
}
