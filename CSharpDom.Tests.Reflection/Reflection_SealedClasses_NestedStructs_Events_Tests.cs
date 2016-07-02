using CSharpDom.TestTarget.SealedClasses.NestedStructs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructsWithEventWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(StructWithNestedStructsWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructsWithEventWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(StructWithNestedStructsWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithEventWithGenericDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithInternalEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPrivateEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPublicEventUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicEvent));
        }
    }
}
