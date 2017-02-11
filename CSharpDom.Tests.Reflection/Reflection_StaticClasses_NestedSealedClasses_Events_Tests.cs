using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedSealedClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithEventWith1AttributeUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithInternalEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithOverrideEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivateEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithSealedOverrideEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
