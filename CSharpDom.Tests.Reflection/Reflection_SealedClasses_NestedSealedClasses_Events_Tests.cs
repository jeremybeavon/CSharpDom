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
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithInternalEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithOverrideEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivateEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithSealedOverrideEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
