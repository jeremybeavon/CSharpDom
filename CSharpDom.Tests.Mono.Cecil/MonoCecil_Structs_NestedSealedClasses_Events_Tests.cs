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
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticEvent));
        }
    }
}
