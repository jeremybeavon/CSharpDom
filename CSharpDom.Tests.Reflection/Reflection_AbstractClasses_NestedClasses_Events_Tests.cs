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
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVirtualEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverrideEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithSealedOverrideEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithVirtualEvent));
        }
    }
}
