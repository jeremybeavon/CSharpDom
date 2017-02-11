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
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNestedClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverrideEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPublicEvent));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNestedClassWithSealedOverrideEventUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideEvent));
        //}

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualEventUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithVirtualEvent));
        }
    }
}
