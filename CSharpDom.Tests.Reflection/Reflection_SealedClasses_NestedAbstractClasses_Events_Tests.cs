using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedAbstractClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventWithGenericDelegateUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewVirtualEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithOverrideEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivateEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithSealedOverrideEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithVirtualEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
