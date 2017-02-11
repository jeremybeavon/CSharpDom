using CSharpDom.TestTarget.Classes.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
