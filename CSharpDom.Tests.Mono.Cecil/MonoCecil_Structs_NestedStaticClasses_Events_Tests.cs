using CSharpDom.TestTarget.Structs.NestedStaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStaticClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithEventWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithInternalEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPrivateEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicEvent));
        }
    }
}
