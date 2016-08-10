using CSharpDom.TestTarget.Classes.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithEventWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverrideEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVirtualEvent));
        }
    }
}
