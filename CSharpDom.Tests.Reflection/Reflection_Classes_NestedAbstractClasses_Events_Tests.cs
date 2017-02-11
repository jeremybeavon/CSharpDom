using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedAbstractClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventWithGenericDelegateUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVirtualEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverrideEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithSealedOverrideEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
