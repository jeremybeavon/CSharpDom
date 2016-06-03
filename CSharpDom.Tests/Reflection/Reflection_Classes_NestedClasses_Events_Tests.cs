using CSharpDom.TestTarget.Classes.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithEventWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventWithGenericDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewVirtualEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithOverrideEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithSealedOverrideEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithVirtualEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVirtualEvent));
        }
    }
}
