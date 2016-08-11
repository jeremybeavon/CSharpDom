using CSharpDom.TestTarget.Classes.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public void TestClassWithNestedClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicEvent));
        }

        //[TestMethod]
        //public void TestClassWithNestedClassWithSealedOverrideEventUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideEvent));
        //}

        [TestMethod]
        public void TestClassWithNestedClassWithStaticEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVirtualEvent));
        }
    }
}
