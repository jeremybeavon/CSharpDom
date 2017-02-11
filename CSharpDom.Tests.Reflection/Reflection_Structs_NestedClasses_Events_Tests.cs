using CSharpDom.TestTarget.Structs.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithEventWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverrideEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithVirtualEvent));
        }
    }
}
