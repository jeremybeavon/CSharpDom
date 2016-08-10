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
            TestStructAsync(typeof(StructWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public void TestStructWithNestedClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverrideEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVirtualEvent));
        }
    }
}
