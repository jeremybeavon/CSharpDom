using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStructs_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructsWithEventWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(StructWithNestedStructsWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructsWithEventWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(StructWithNestedStructsWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithEventWithGenericDelegateUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithInternalEventUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPrivateEventUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPublicEventUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicEvent));
        }
    }
}
