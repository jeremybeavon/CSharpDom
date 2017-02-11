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
            TestStruct(typeof(StructWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventWithGenericDelegateUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverrideEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
