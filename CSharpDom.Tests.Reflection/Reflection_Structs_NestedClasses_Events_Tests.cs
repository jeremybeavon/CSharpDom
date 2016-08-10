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
            TestStructAsync(typeof(StructWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventWithGenericDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverrideEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVirtualEvent));
        }
    }
}
