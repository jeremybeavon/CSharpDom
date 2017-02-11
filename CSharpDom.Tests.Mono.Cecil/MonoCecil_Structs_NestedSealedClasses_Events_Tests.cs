using CSharpDom.TestTarget.Structs.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedSealedClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithStaticEvent));
        }
    }
}
