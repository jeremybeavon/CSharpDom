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
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventWithGenericDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVirtualEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverrideEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithSealedOverrideEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
