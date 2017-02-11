using CSharpDom.TestTarget.Classes.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithEventWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithEventWithGenericDelegateUsingReflection()
        {
            TestClass(typeof(ClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithInternalEventUsingReflection()
        {
            TestClass(typeof(ClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNewEventUsingReflection()
        {
            TestClass(typeof(ClassWithNewEvent));
        }

        [TestMethod]
        public void TestClassWithNewStaticEventUsingReflection()
        {
            TestClass(typeof(ClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNewVirtualEventUsingReflection()
        {
            TestClass(typeof(ClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestClassWithOverrideEventUsingReflection()
        {
            TestClass(typeof(ClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithPrivateEventUsingReflection()
        {
            TestClass(typeof(ClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithProtectedEventUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalEventUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestClassWithPublicEventUsingReflection()
        {
            TestClass(typeof(ClassWithPublicEvent));
        }

        [TestMethod]
        public void TestClassWithSealedOverrideEventUsingReflection()
        {
            TestClass(typeof(ClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithStaticEventUsingReflection()
        {
            TestClass(typeof(ClassWithStaticEvent));
        }

        [TestMethod]
        public void TestClassWithVirtualEventUsingReflection()
        {
            TestClass(typeof(ClassWithVirtualEvent));
        }
    }
}
