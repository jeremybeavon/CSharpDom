using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedSealedClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithInternalEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithOverrideEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivateEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithSealedOverrideEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
