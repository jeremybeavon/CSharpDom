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
            TestClassAsync(typeof(ClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithEventWithGenericDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithInternalEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNewEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewEvent));
        }

        [TestMethod]
        public void TestClassWithNewStaticEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNewVirtualEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestClassWithOverrideEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithPrivateEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithProtectedEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestClassWithPublicEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPublicEvent));
        }

        [TestMethod]
        public void TestClassWithSealedOverrideEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithStaticEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithStaticEvent));
        }

        [TestMethod]
        public void TestClassWithVirtualEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithVirtualEvent));
        }
    }
}
