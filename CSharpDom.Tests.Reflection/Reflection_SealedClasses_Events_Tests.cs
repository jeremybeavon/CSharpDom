using CSharpDom.TestTarget.SealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithEventWith1AttributeUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithInternalEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNewEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithOverrideEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithPublicEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverrideEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithStaticEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithStaticEvent));
        }
    }
}
