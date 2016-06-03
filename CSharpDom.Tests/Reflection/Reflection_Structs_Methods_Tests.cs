using CSharpDom.TestTarget.Structs.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithInternalMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithInternalMethod));
        }

        [TestMethod]
        public async Task TestStructWithPrivateMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestStructWithPublicMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithPublicMethod));
        }

        [TestMethod]
        public async Task TestStructWithStaticMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithStaticMethod));
        }
    }
}
