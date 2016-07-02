using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedAbstractClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventWithGenericDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewVirtualEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithOverrideEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivateEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithSealedOverrideEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithVirtualEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
