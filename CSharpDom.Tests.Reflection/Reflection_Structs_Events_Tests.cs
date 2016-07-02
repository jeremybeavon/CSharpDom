using CSharpDom.TestTarget.Structs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithInternalEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithPrivateEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStructWithPublicEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithPublicEvent));
        }

        [TestMethod]
        public async Task TestStructWithStaticEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithStaticEvent));
        }
    }
}
