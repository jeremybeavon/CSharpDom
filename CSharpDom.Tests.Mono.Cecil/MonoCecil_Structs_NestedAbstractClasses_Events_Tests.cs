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
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public void TestStructWithNestedAbstractClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverrideEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
