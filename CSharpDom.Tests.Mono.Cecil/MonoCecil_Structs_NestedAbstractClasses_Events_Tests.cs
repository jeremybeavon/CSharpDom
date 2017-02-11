using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public void TestStructWithNestedAbstractClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPublicEvent));
        }

        //[TestMethod]
        //public void TestStructWithNestedAbstractClassWithSealedOverrideEventUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideEvent));
        //}

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
