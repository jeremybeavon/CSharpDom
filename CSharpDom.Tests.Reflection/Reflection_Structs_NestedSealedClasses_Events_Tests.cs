using CSharpDom.TestTarget.Structs.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithEventWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(AbstractClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(AbstractClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEventWithGenericDelegateUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithOverrideEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivateEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithSealedOverrideEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticEvent));
        }
    }
}
