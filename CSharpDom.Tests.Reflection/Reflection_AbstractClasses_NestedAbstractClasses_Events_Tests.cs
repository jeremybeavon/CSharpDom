using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedAbstractClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithEventWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithEventWithGenericDelegateUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithInternalEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewStaticEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewVirtualEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithOverrideEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPrivateEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedInternalEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPublicEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithSealedOverrideEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithStaticEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithVirtualEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
