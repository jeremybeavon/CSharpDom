using CSharpDom.TestTarget.SealedClasses.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVirtualEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverrideEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualEvent));
        }
    }
}
