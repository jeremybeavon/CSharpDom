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
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventWithGenericDelegateUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewVirtualEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithOverrideEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivateEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithSealedOverrideEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithVirtualEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
