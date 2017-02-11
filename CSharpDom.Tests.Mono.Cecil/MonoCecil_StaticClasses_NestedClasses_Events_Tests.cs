using CSharpDom.TestTarget.StaticClasses.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalEventUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewEventUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticEventUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public void TestStaticClassWithNestedClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideEventUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateEventUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedEventUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicEventUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPublicEvent));
        }

        //[TestMethod]
        //public void TestStaticClassWithNestedClassWithSealedOverrideEventUsingMonoCecil()
        //{
        //    TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideEvent));
        //}

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticEventUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualEventUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithVirtualEvent));
        }
    }
}
