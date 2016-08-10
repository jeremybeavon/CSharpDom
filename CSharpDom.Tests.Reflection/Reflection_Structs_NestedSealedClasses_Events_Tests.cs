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
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticEvent));
        }
    }
}
