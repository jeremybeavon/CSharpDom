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
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithEventWithGenericDelegateUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithInternalEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewStaticEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewVirtualEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithOverrideEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPrivateEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedInternalEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPublicEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithSealedOverrideEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithStaticEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithVirtualEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
