using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStructs_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructsWithEventWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(StructWithNestedStructsWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructsWithEventWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(StructWithNestedStructsWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithEventWithGenericDelegateUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithInternalEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPrivateEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPublicEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicEvent));
        }
    }
}
