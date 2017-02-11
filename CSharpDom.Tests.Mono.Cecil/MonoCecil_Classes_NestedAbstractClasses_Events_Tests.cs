using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public void TestClassWithNestedAbstractClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverrideEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPublicEvent));
        }

        //[TestMethod]
        //public void TestClassWithNestedAbstractClassWithSealedOverrideEventUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideEvent));
        //}

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
