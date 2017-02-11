using CSharpDom.TestTarget.Structs.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithStaticEvent));
        }
    }
}
