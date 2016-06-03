using CSharpDom.TestTarget.Structs.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithInternalEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithPrivateEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithPublicEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithStaticEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithStaticEventProperty));
        }
    }
}
