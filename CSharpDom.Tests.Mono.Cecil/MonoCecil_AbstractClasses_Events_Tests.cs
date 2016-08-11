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
            TestAbstractClassAsync(typeof(AbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNewEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public void TestAbstractClassWithOverrideEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicEvent));
        }

        //[TestMethod]
        //public void TestAbstractClassWithSealedOverrideEventUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideEvent));
        //}

        [TestMethod]
        public void TestAbstractClassWithStaticEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithVirtualEvent));
        }
    }
}
