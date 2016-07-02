using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithEventWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(AbstractClassWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(AbstractClassWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventWithGenericDelegateUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewVirtualEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithOverrideEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithSealedOverrideEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithVirtualEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
