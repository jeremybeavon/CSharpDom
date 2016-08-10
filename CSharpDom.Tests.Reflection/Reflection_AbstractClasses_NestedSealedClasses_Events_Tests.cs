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
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithInternalEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewStaticEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithOverrideEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPrivateEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedInternalEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPublicEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithSealedOverrideEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithStaticEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
