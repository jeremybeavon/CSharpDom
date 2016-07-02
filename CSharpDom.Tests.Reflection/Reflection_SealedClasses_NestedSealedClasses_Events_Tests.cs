using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedSealedClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithEventWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(AbstractClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(AbstractClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithEventWithGenericDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithInternalEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewStaticEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithOverrideEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPrivateEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedInternalEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPublicEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithSealedOverrideEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithStaticEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
