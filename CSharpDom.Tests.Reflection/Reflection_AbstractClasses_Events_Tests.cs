using CSharpDom.TestTarget.AbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithEventWith1AttributeUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithEventWithGenericDelegateUsingReflection()
        { 
            TestAbstractClass(typeof(AbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNewEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithOverrideEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithPublicEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverrideEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithVirtualEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }
    }
}
