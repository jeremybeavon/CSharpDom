using CSharpDom.TestTarget.AbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNewEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public void TestAbstractClassWithOverrideEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithPublicEvent));
        }

        //[TestMethod]
        //public void TestAbstractClassWithSealedOverrideEventUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideEvent));
        //}

        [TestMethod]
        public void TestAbstractClassWithStaticEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithVirtualEvent));
        }
    }
}
