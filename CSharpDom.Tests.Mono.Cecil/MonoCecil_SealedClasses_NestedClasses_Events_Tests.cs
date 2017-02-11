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
            TestSealedClass(typeof(SealedClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPublicEvent));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedClassWithSealedOverrideEventUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideEvent));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithVirtualEvent));
        }
    }
}
