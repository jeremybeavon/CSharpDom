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
            TestClass(typeof(ClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public void TestClassWithNestedClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithPublicEvent));
        }

        //[TestMethod]
        //public void TestClassWithNestedClassWithSealedOverrideEventUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideEvent));
        //}

        [TestMethod]
        public void TestClassWithNestedClassWithStaticEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithVirtualEvent));
        }
    }
}
