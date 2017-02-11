using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedSealedClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEventWith1AttributeUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithInternalEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithOverrideEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivateEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithSealedOverrideEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
