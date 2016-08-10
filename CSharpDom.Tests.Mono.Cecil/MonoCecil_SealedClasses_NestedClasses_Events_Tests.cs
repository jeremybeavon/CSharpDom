using CSharpDom.TestTarget.SealedClasses.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverrideEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualEvent));
        }
    }
}
