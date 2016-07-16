using CSharpDom.TestTarget.Structs.NestedStructs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructsWithEventWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructsWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithEventWithGenericDelegateUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicEvent));
        }
    }
}
