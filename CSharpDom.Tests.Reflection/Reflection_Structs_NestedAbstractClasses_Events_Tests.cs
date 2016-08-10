using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventWithGenericDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverrideEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
