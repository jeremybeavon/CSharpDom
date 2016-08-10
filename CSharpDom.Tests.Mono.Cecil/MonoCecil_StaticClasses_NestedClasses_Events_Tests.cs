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
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public void TestStaticClassWithNestedClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithSealedOverrideEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualEvent));
        }
    }
}
