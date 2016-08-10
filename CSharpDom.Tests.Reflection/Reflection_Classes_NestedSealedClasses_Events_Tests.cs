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
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
