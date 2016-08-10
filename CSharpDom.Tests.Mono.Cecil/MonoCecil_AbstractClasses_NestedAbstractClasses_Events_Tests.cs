using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedAbstractClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithInternalEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewStaticEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNestedAbstractClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithOverrideEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPrivateEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPublicEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPublicEvent));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNestedAbstractClassWithSealedOverrideEventUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithSealedOverrideEvent));
        //}

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithStaticEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithVirtualEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
