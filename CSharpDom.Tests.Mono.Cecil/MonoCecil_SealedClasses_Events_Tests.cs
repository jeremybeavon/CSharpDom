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
            TestSealedClassAsync(typeof(SealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithInternalEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNewEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithOverrideEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithPublicEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverrideEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithStaticEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticEvent));
        }
    }
}
