using CSharpDom.TestTarget.SealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithInternalEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNewEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithOverrideEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithPublicEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverrideEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithStaticEventUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithStaticEvent));
        }
    }
}
