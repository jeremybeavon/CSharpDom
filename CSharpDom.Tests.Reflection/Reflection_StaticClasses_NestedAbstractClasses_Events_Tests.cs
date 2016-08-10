using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedAbstractClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithEventWith1AttributeUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithEventWithGenericDelegateUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithInternalEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewVirtualEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithOverrideEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPrivateEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedInternalEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPublicEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithSealedOverrideEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithVirtualEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
