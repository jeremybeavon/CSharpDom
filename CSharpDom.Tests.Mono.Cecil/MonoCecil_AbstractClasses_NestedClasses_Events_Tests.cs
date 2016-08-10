using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNestedClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverrideEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicEvent));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNestedClassWithSealedOverrideEventUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideEvent));
        //}

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualEvent));
        }
    }
}
