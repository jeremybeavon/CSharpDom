using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedSealedClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithInternalEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewStaticEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithOverrideEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPrivateEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPublicEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithSealedOverrideEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithStaticEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
