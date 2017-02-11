using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedSealedClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEventWith1AttributeUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithInternalEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewStaticEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithOverrideEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPrivateEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedInternalEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPublicEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithSealedOverrideEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithStaticEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
