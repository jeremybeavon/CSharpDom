using CSharpDom.TestTarget.Structs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithInternalEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithPrivateEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStructWithPublicEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithPublicEvent));
        }

        [TestMethod]
        public async Task TestStructWithStaticEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithStaticEvent));
        }
    }
}
