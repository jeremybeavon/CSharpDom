using CSharpDom.TestTarget.Structs.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithInternalEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithPrivateEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithPublicEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithStaticEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithStaticEventProperty));
        }
    }
}
