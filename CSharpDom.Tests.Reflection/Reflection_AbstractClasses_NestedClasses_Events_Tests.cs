using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVirtualEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverrideEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithSealedOverrideEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualEvent));
        }
    }
}
