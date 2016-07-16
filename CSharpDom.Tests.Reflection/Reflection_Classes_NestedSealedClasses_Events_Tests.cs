using CSharpDom.TestTarget.Classes.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithEventWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithEventWithGenericDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithInternalEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewStaticEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithOverrideEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPrivateEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedInternalEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithSealedOverrideEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithStaticEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
