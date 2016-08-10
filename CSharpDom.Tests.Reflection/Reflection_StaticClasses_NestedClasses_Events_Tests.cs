using CSharpDom.TestTarget.StaticClasses.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventWith1AttributeUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVirtualEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithSealedOverrideEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualEvent));
        }
    }
}
