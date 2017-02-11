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
            TestClass(typeof(ClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestClass(typeof(ClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithInternalEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNewEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNewEvent));
        }

        [TestMethod]
        public void TestClassWithNewStaticEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public void TestClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public void TestClassWithOverrideEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithPrivateEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithProtectedEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestClassWithPublicEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPublicEvent));
        }

        //[TestMethod]
        //public void TestClassWithSealedOverrideEventUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithSealedOverrideEvent));
        //}

        [TestMethod]
        public void TestClassWithStaticEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithStaticEvent));
        }

        [TestMethod]
        public void TestClassWithVirtualEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithVirtualEvent));
        }
    }
}
