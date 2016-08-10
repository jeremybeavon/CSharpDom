using CSharpDom.TestTarget.Classes.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedSealedClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
