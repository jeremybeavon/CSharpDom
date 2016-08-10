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
            TestAbstractClassAsync(typeof(AbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithEventWithGenericDelegateUsingReflection()
        { 
            TestAbstractClassAsync(typeof(AbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNewEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithOverrideEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverrideEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithVirtualEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }
    }
}
