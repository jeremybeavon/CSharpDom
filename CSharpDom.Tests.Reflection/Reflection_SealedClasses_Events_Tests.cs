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
            TestSealedClassAsync(typeof(SealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithInternalEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNewEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithOverrideEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithPublicEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverrideEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithStaticEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticEvent));
        }
    }
}
