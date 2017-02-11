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
            TestStaticClass(typeof(StaticClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVirtualEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithSealedOverrideEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithVirtualEvent));
        }
    }
}
