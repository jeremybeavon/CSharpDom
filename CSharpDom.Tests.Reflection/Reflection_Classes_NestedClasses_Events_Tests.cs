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
            TestClass(typeof(ClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverrideEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithVirtualEvent));
        }
    }
}
