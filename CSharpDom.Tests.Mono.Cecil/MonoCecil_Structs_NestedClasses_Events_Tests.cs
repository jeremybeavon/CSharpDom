using CSharpDom.TestTarget.Structs.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public void TestStructWithNestedClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithPublicEvent));
        }

        //[TestMethod]
        //public void TestStructWithNestedClassWithSealedOverrideEventUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideEvent));
        //}

        [TestMethod]
        public void TestStructWithNestedClassWithStaticEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithVirtualEvent));
        }
    }
}
