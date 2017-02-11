using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedSealedClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithInternalEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithOverrideEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivateEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithSealedOverrideEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
