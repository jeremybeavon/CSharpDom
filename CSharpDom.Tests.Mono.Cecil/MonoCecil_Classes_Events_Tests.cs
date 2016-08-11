using CSharpDom.TestTarget.Classes.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithInternalEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNewEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNewEvent));
        }

        [TestMethod]
        public void TestClassWithNewStaticEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public void TestClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public void TestClassWithOverrideEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithPrivateEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithProtectedEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestClassWithPublicEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPublicEvent));
        }

        //[TestMethod]
        //public void TestClassWithSealedOverrideEventUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithSealedOverrideEvent));
        //}

        [TestMethod]
        public void TestClassWithStaticEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithStaticEvent));
        }

        [TestMethod]
        public void TestClassWithVirtualEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithVirtualEvent));
        }
    }
}
