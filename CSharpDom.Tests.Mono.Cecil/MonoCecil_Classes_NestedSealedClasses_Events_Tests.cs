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
            TestClass(typeof(ClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
