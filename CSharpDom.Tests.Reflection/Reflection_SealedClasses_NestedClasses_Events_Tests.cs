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
            TestSealedClass(typeof(SealedClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVirtualEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverrideEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithVirtualEvent));
        }
    }
}
