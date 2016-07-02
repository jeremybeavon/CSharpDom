using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStaticClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithEventWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithEventWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithInternalEventUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPrivateEventUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPublicEventUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicEvent));
        }
    }
}
