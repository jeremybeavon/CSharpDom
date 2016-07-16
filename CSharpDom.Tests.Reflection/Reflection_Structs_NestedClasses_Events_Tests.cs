using CSharpDom.TestTarget.Structs.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(AbstractClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventWithGenericDelegateUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewVirtualEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithOverrideEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithSealedOverrideEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVirtualEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVirtualEvent));
        }
    }
}
